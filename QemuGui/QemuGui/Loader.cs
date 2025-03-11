using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace QEMUInterface
{
    public class Loader
    {
        private static readonly string FILE_EXT = ".qint";
        private static readonly string[] requiredKeys = ["name", "os", "type", "machine", "cores", "memory", "graphics", "audio"];
        private static readonly string[] acceptableFlags = ["verbose"];

        private string path;

        public Loader()
        {
            path = Properties.Settings.Default.vmFolder;
        }

        public List<VirtualMachine> Populate()
        {
            List<VirtualMachine> machines = [];

            if (path == null)
            {
                return machines;
            }

            try
            {
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(s => Path.GetExtension(s) == FILE_EXT);

                foreach (var file in files)
                {
                    string content = File.ReadAllText(file);
                    if (content == null)
                    {
                        continue;
                    }

                    JsonNode? parsed = null;
                    try
                    {
                        parsed = JsonNode.Parse(content);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Error loading machine: \"{file}\".\n\nThe data is malformed.", "Failed to load VM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    if (parsed == null)
                    {
                        continue;
                    }

                    if (ValidateJson(parsed))
                    {
                        _ = Enum.TryParse(parsed["type"]!.ToString().ToUpper(), out PC_TYPE pcType);
                        _ = Enum.TryParse(parsed["graphics"]!.ToString().ToUpper(), out GRAPHICS_TYPE graphicsType);
                        VirtualMachine vm = new()
                        {
                            Name = parsed["name"]!.ToString(),
                            FilePath = path,
                            OperatingSystem = OperatingSystems.get(parsed["os"]!.ToString()),
                            PCType = pcType,
                            Machine = parsed["machine"]!.ToString(),
                            CPUCoreCount = int.Parse(parsed["cores"]!.ToString()),
                            MemorySize = int.Parse(parsed["memory"]!.ToString()),
                            GraphicsType = graphicsType,
                        };

                        if (parsed["processName"] != null && parsed["processArgs"] != null)
                        {
                            vm.ProcessName = parsed["processName"]!.ToString();
                            vm.ProcessArgs = parsed["processArgs"]!.ToString();
                        }

                        machines.Add(vm);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show($"Error loading machine: \"{file}\".\nRequired data is missing.\n\nWould you like to repair it?", "Failed to load VM", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            VirtualMachine vm = new(true)
                            {
                                FilePath = file
                            };

                            try { vm.Name = parsed["name"].ToString(); }
                            catch (Exception) { }
                            try { vm.OperatingSystem = OperatingSystems.get(parsed["os"].ToString()); }
                            catch (Exception) { }
                            try
                            {
                                _ = Enum.TryParse(parsed["type"].ToString().ToUpper(), out PC_TYPE pcType);
                                vm.PCType = pcType;
                            }
                            catch (Exception) { }
                            try { vm.Machine = parsed["machine"].ToString(); }
                            catch (NullReferenceException) { }
                            try { vm.CPUCoreCount = int.Parse(parsed["cores"].ToString()); }
                            catch (Exception) { }
                            try { vm.MemorySize = int.Parse(parsed["memory"].ToString()); }
                            catch (Exception) { }
                            try
                            {
                                _ = Enum.TryParse(parsed["graphics"]!.ToString().ToUpper(), out GRAPHICS_TYPE graphicsType);
                                vm.GraphicsType = graphicsType;
                            }
                            catch (Exception) { }

                            if (parsed["processName"] != null && parsed["processArgs"] != null)
                            {
                                vm.ProcessName = parsed["processName"]!.ToString();
                                vm.ProcessArgs = parsed["processArgs"]!.ToString();
                            }

                            new WIN_NewMachine((vm) =>
                            {
                                machines.Add(vm);
                                StoreVM(vm, file);
                            }, vm).ShowDialog();
                        }
                    }
                }
            }
            catch (Exception)
            {
                return machines;
            }

            return machines;
        }

        public bool ValidateJson(JsonNode inp)
        {
            foreach (string k in requiredKeys)
            {
                if (inp[k] == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void StoreVM(VirtualMachine vm)
        {
            if (path == null)
            {
                return;
            }

            StoreVM(vm, Path.Combine(path, vm.Name + FILE_EXT));
        }
        public void StoreVM(VirtualMachine vm, string filePath)
        {

            string content = "{\n";
            content += $"\"name\": \"{vm.Name}\",\n";
            content += $"\"os\": \"{vm.OperatingSystem.Name}\",\n";
            content += $"\"type\": \"{vm.PCType}\",\n";
            content += $"\"machine\": \"{vm.Machine}\",\n";
            content += $"\"cores\": {vm.CPUCoreCount},\n";
            content += $"\"memory\": {vm.MemorySize},\n";
            content += $"\"graphics\": \"{vm.GraphicsType}\",\n";
            content += $"\"audio\": \"{vm.AudioType}\",\n";
            content += $"\"processName\": \"{vm.ProcessName}\",\n";
            content += $"\"processArgs\": \"{vm.ProcessArgs}\"\n";
            content += "}";

            File.WriteAllText(filePath, content);
        }
    }
}

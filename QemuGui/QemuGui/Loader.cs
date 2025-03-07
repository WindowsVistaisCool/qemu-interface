using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace QEMUInterface
{
    public class Loader
    {
        private static readonly string FILE_EXT = ".qint";
        private static readonly string[] requiredKeys = ["name", "os", "type", "pc", "cores", "memory"];
        private static readonly string[] acceptableFlags = ["verbose"];

        private string? path;

        public Loader()
        {
            path = Properties.Settings.Default.vmFolder;
        }

        public List<VirtualMachine> populate()
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
                    } catch (Exception)
                    {
                        MessageBox.Show($"Error loading machine: \"{file}\".\n\nThe data is malformed.", "Failed to load VM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                    if (parsed == null)
                    {
                        continue;
                    }

                    if (validateJson(parsed))
                    {
                        _ = Enum.TryParse(parsed["type"]!.ToString().ToUpper(), out PC_TYPE type);
                        VirtualMachine vm = new(file, parsed["name"]!.ToString())
                        {
                            OperatingSystem = OperatingSystems.get(parsed["os"]!.ToString()),
                            PCType = type,
                            Machine = parsed["pc"]!.ToString(),
                            CPUCoreCount = int.Parse(parsed["cores"]!.ToString()),
                            MemorySize = int.Parse(parsed["memory"]!.ToString())
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
                        MessageBox.Show($"Error loading machine: \"{file}\".\n\nRequired data is missing.", "Failed to load VM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception)
            {
                return machines;
            }

            return machines;
        }

        public bool validateJson(JsonNode inp)
        {
            foreach (string k in requiredKeys) {
                if (inp[k] == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void storeVM(VirtualMachine vm)
        {
            if (path == null)
            {
                return;
            }

            string content = "{\n";
            content += $"\"name\": \"{vm.Name}\",\n";
            content += $"\"os\": \"{vm.OperatingSystem.Name}\",\n";
            content += $"\"processName\": \"{vm.ProcessName}\",\n";
            content += $"\"processArgs\": \"{vm.ProcessArgs}\"\n";
            content += "}";

            File.WriteAllText(Path.Combine(path, vm.Name + FILE_EXT), content);
        }
    }
}

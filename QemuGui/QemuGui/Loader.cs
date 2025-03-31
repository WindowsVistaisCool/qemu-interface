﻿using System;
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

                    VirtualMachine vm = new VirtualMachine();

                    if (ParseJson(vm, parsed))
                    {
                        //_ = Enum.TryParse(parsed["type"]!.ToString().ToUpper(), out PC_TYPE pcType);
                        //_ = Enum.TryParse(parsed["graphics"]!.ToString().ToUpper(), out GRAPHICS_TYPE graphicsType);
                        //VirtualMachine vm = new()
                        //{
                        //    Name = parsed["name"]!.ToString(),
                        //    FilePath = file,
                        //    OperatingSystem = OperatingSystems.get(parsed["os"]!.ToString()),
                        //    PCType = pcType,
                        //    Machine = parsed["machine"]!.ToString(),
                        //    CPUCoreCount = int.Parse(parsed["cores"]!.ToString()),
                        //    Memory = int.Parse(parsed["memory"]!.ToString()),
                        //    Graphics = graphicsType,
                        //};

                        //if (parsed["processName"] != null && parsed["processArgs"] != null)
                        //{
                        //    vm.ProcessName = parsed["processName"]!.ToString();
                        //    vm.ProcessArgs = parsed["processArgs"]!.ToString();
                        //}

                        machines.Add(vm);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show($"Error loading machine: \"{file}\".\nRequired data is missing.\n\nWould you like to repair it?", "Failed to load VM", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            vm = new(true)
                            {
                                FilePath = file
                            };

                            try { vm.Name = parsed["Name"].ToString(); }
                            catch (Exception) { }
                            try { vm.OperatingSystem = OperatingSystems.get(parsed["Specs"]["OS"].ToString()); }
                            catch (Exception) { }
                            try
                            {
                                _ = Enum.TryParse(parsed["Specs"]["PCType"].ToString().ToUpper(), out PC_TYPE pcType);
                                vm.PCType = pcType;
                            }
                            catch (Exception) { }
                            try { vm.Machine = parsed["Specs"]["Machine"].ToString(); }
                            catch (NullReferenceException) { }
                            try { vm.CPUCoreCount = int.Parse(parsed["Specs"]["CPU"]["Cores"].ToString()); }
                            catch (Exception) { }
                            try { vm.Memory = int.Parse(parsed["Specs"]["Memory"].ToString()); }
                            catch (Exception) { }
                            try
                            {
                                _ = Enum.TryParse(parsed["Specs"]!["Graphics"]!.ToString().ToUpper(), out GRAPHICS_TYPE graphicsType);
                                vm.Graphics = graphicsType;
                            }
                            catch (Exception) { }

                            //if (parsed["processName"] != null && parsed["processArgs"] != null)
                            //{
                            //    vm.ProcessName = parsed["processName"]!.ToString();
                            //    vm.ProcessArgs = parsed["processArgs"]!.ToString();
                            //}

                            new WIN_NewMachine((vm, shouldLaunchMedia) =>
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

        public static bool ParseJson(VirtualMachine vm, JsonNode inp)
        {
            foreach (KeyValuePair<string, object> k1 in VirtualMachine.MinimumDataRequired())
            {
                if (k1.Value.GetType() == typeof(int))
                {
                    if (inp[k1.Key] != null)
                    {
                        vm.SetVarString(k1.Key, inp[k1.Key]!.ToString());
                        MessageBox.Show(inp[k1.Key]!.ToString());
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (k1.Value.GetType() =
                    = typeof(Dictionary<string, object>))
                {
                    foreach (KeyValuePair<string, object> k2 in (Dictionary<string, object>)k1.Value)
                    {
                        if (inp[k1.Key] != null && inp[k1.Key]![k2.Key] != null)
                        {
                            vm.SetVarString(k2.Key, inp[k1.Key]![k2.Key]!.ToString());
                        }
                        else
                        {
                            return false;
                        }
                    }
                }

            }
            // Do additional parsing of optional data

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
            File.WriteAllText(filePath, vm.ToString());
        }
    }
}

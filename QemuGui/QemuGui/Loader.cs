using System.Text.Json.Nodes;

namespace QEMUInterface
{
    public class Loader
    {
        public static readonly string FILE_EXT = ".qint";

        public static readonly string CONFIG_FILE = "config" + FILE_EXT;
        //private static readonly string[] acceptableFlags = ["verbose"];

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
                var folders = Directory.EnumerateDirectories(path);

                foreach (var folder in folders)
                {
                    if (!File.Exists(Path.Combine(folder, CONFIG_FILE)))
                    {
                        continue;
                    }

                    var file = Path.Combine(folder, CONFIG_FILE);

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
                    vm.VMDirectory = folder;

                    if (ParseJson(vm, parsed))
                    {

                        machines.Add(vm);
                    }
                    else
                    {
                        // OLD!!! TODO: DELETE AND UPDATE RECOVERY CODE 
                        DialogResult result = MessageBox.Show($"Error loading machine: \"{file}\".\nRequired data is missing.\n\nWould you like to repair it?", "Failed to load VM", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            vm = new(true)
                            {
                                VMDirectory = file
                            };

                            try { vm.Name = parsed["Name"].ToString(); }
                            catch (Exception) { }
                            try { vm.OS = OperatingSystems.get(parsed["Specs"]["OS"].ToString()); }
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
            // Load uuid first
            if (inp["UUID"] != null)
            {
                vm.UUID = inp["UUID"]!.ToString();
            }
            else
            {
                return false;
            }

            foreach (KeyValuePair<string, object> k1 in VirtualMachine.MinimumDataRequired())
            {
                if (k1.Value.GetType() == typeof(int))
                {
                    if (inp[k1.Key] != null)
                    {
                        vm.SetVarString(k1.Key, inp[k1.Key]!.ToString());
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (k1.Value.GetType() == typeof(Dictionary<string, object>))
                {

                    // TODO: Add a while loop for nested parsing
                    Dictionary<string, object> value = (Dictionary<string, object>)k1.Value;
                    foreach (KeyValuePair<string, object> k2 in value)
                    {
                        if (inp[k1.Key] != null && inp[k1.Key]![k2.Key] != null)
                        {
                            var toSet = inp[k1.Key]![k2.Key]!.ToString();
                            if (int.TryParse(toSet, out int numResult)) // Integer
                            {
                                vm.SetVarString(k2.Key, numResult);
                            }
                            else // String
                            {
                                vm.SetVarString(k2.Key, toSet);
                            }
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

        public void StoreVM(VirtualMachine vm, bool overwriteFile)
        {
            if (path == null)
            {
                return;
            }

            bool directoryExists = Directory.Exists(Path.Combine(path, vm.UUID));


            if (directoryExists && !overwriteFile)
            {
                MessageBox.Show("Error storing VM!\n\nA VM with the same UUID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!directoryExists)
            {
                Directory.CreateDirectory(Path.Combine(path, vm.UUID));
            }

            //if (File.Exists(Path.Combine(path, vm.UUID + FILE_EXT)) && !overwriteFile) {
            //}

            StoreVM(vm, Path.Combine(path, Path.Combine(vm.UUID, CONFIG_FILE)));
        }
        public void StoreVM(VirtualMachine vm)
        {
            StoreVM(vm, false);
        }
        public void StoreVM(VirtualMachine vm, string filePath)
        {
            File.WriteAllText(filePath, vm.ToString());
        }

        public void DeleteVM(VirtualMachine vm)
        {
            if (!Directory.Exists(vm.VMDirectory))
            {
                return;
            }

            try
            {
                Directory.Delete(vm.VMDirectory, true);
            } catch (Exception)
            { }
        }
    }
}


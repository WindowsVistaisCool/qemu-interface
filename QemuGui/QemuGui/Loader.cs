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
        private static readonly string[] requiredKeys = ["name", "os"];
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

            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(s => Path.GetExtension(s) == FILE_EXT);

            foreach (var file in files)
            {
                string content = File.ReadAllText(file);
                if (content == null)
                {
                    continue;
                }
                JsonNode? parsed = JsonNode.Parse(content);
                if (parsed == null)
                {
                    continue;
                }

                if (validateJson(parsed))
                {
                    VirtualMachine vm = new(file, parsed["name"]!.ToString())
                    {
                        operatingSystem = OperatingSystems.get(parsed["os"]!.ToString())
                    };

                    if (parsed["processName"] != null && parsed["processArgs"] != null)
                    {
                        vm.processName = parsed["processName"]!.ToString();
                        vm.processArgs = parsed["processArgs"]!.ToString();
                    }

                    machines.Add(vm);
                }
            }

            return machines;
        }

        public bool validateJson(JsonNode inp)
        {
            try
            {
                foreach (string k in requiredKeys)
                {
                    _ = inp[k];
                }
            } catch (NullReferenceException)
            {
                return false;
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
            content += $"\"os\": \"{vm.operatingSystem.Name}\",\n";
            content += $"\"processName\": \"{vm.processName}\",\n";
            content += $"\"processArgs\": \"{vm.processArgs}\"\n";
            content += "}";

            File.WriteAllText(Path.Combine(path, vm.Name + FILE_EXT), content);
        }
    }
}

﻿using System.Diagnostics;

namespace QEMUInterface
{
    public enum OS_FAMILY
    {
        WINDOWS,
        MACOS,
        LINUX,
        OTHER
    }

    public enum PC_TYPE
    {
        IA_32,
        ITANIUM,
        X86_64,
        AARCH64,
        MIPS,
        PPC,
        RISCV,
        M68K,
        XTENSA,
        OTHER
    }

    public enum MEDIA_TYPE
    {
        HDD,
        CDROM,
        FLOPPY
    }

    public enum GRAPHICS_TYPE
    {
        STD,
        CIRRUS,
        VMWARE,
        QXL,
        XENFB,
        TCX,
        CG3,
        VIRTIO,
        NONE
    }

    public readonly struct OperatingSystem
    {
        public readonly OS_FAMILY Family;
        public readonly string Name;
        public readonly string FriendlyName;
        public readonly bool[] Bitness; // [32, 64]
        public readonly PC_TYPE[] Compatability;
        public readonly string[] MinorVers; // TODO: convert this to operating system array of minor versions
        public readonly int ImageIndex;

        public OperatingSystem(OS_FAMILY family, string name, string friendlyName, int imageIndex, bool[] bitness, PC_TYPE[] compatability, string[] minorVers)
        {
            Family = family;
            Name = name;
            FriendlyName = friendlyName;
            Bitness = bitness;
            Compatability = compatability;
            MinorVers = minorVers;
            ImageIndex = imageIndex;
        }

        public OperatingSystem(OS_FAMILY family, string name, int imageIndex, bool[] bitness, PC_TYPE compatability, string[] minorVers)
        {
            Family = family;
            Name = name;
            FriendlyName = name;
            Bitness = bitness;
            Compatability = [compatability];
            MinorVers = minorVers;
            ImageIndex = imageIndex;
        }

    }

    public static class QemuMachines
    {
        public static string getQemuCmd(PC_TYPE type)
        {
            switch (type)
            {
                case PC_TYPE.X86_64:
                    return "qemu-system-x86_64.exe";
                case PC_TYPE.PPC:
                    return "qemu-system-ppc.exe";
                case PC_TYPE.AARCH64:
                    return "qemu-system-aarch64.exe";
                case PC_TYPE.MIPS:
                    return "qemu-system-mips.exe";
                case PC_TYPE.M68K:
                    return "qemu-system-m68k.exe";
                default:
                    return "qemu-system-x86_64.exe";
            }
        }

        public static string getFriendlyPCName(PC_TYPE type)
        {
            string[] names = ["Intel Architecture 32-bit", "Intel Itanium", "x86/x64", "ARM 64-Bit", "MIPS", "Power-PC", "RISC-V", "Motorola 68k", "Xtensa", "Other Architecture"];
            return names[(int)type];
        }

        public static void getPCTypesAsync(PC_TYPE type, Action<List<string[]>> machines) {
            string param = $"$ex = '{getQemuCmd(type)} -machine help';";
            string regex = @"^\s*(?<Name>[^\s]+)\s+(?<Desc>.+)$";
            string script = param + @"
                $f = $false;
                $(Invoke-Expression $ex) -split '\r?\n' | Select-Object -Skip 1 | ForEach-Object {
                    if ($_ -match 'Recognized CPUID flags:') {
                        $f = $true;
                    }
                    if ($f -eq $false -and $_ -match 'REGEX_GOES_HERE') {
                        Write-Host $Matches['Name']','$Matches['Desc'];
                    }
                }
            ".Replace("REGEX_GOES_HERE", regex);
            Action<List<string>> translator = (s) => {
                List<string[]> ret = [];
                foreach (string line in s)
                {
                    if (line.Length == 0) continue;
                    string[] parts = line.Split(',');
                    if (parts.Length < 2) continue;
                    ret.Add([parts[0].Trim(), parts[1].Trim()]);
                }
                machines(ret);
            };
            getInternalAsync(script, translator);
        }

        public static void getAudioTypesAsync(PC_TYPE type, Action<List<string>> audio)
        {
            string script = $"$ex = '{getQemuCmd(type)} -audio help';" + @"
                $(Invoke-Expression $ex) -split '\r?\n' | Select-Object -Skip 1 | ForEach-Object {
                    Write-Host $_;
                }
            ";
            getInternalAsync(script, audio);
        }


        private static void getInternalAsync(string script, Action<List<string>> ret)
        {            
            ProcessStartInfo psi = new()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"{script}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new()
            {
                StartInfo = psi
            };

            List<string> lines = [];

            Thread capture = new(() =>
            {
                while (!process.StandardOutput.EndOfStream)
                {
                    try
                    {
                        lines.Add(process.StandardOutput.ReadLine()!);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show($"Internal script fetch error':\n\n{e}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                ret(lines);
            });

            process.Start();
            capture.Start();
        }
    }

    public static class OperatingSystems
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        private static List<OperatingSystem> allSystems;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        private static void loadSystems() => allSystems ??= [
            new(OS_FAMILY.WINDOWS, "Windows 3.1",       "Windows 3.1", 0, [true, false], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
            new(OS_FAMILY.WINDOWS, "Windows 95",        "Windows 95", 0, [true, false], [PC_TYPE.IA_32], []),
            new(OS_FAMILY.WINDOWS, "Windows 98",        "Windows 98", 0, [true, false], [PC_TYPE.IA_32], []),
            new(OS_FAMILY.WINDOWS, "Windows NT 3.X",    "Windows NT 3.X", 0, [true, false], [PC_TYPE.IA_32, PC_TYPE.X86_64, PC_TYPE.MIPS, PC_TYPE.PPC], []),
            new(OS_FAMILY.WINDOWS, "Windows NT 4",      "Windows NT 4", 0, [true, false], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
            new(OS_FAMILY.WINDOWS, "Windows ME",        "Windows ME", 0, [true, false], [PC_TYPE.IA_32], []),
            new(OS_FAMILY.WINDOWS, "Windows 2000",      "Windows 2000", 0, [true, false], [PC_TYPE.IA_32], []),
            new(OS_FAMILY.WINDOWS, "Windows XP",        "Windows XP", 1, [true, false], [PC_TYPE.IA_32, PC_TYPE.X86_64, PC_TYPE.ITANIUM], []),
            new(OS_FAMILY.WINDOWS, "Windows Vista",     "Windows Vista", 2, [true, false], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
            new(OS_FAMILY.WINDOWS, "Windows 7",         "Windows 7", 3, [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
            new(OS_FAMILY.WINDOWS, "Windows 8",         "Windows 8", 4, [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
            new(OS_FAMILY.WINDOWS, "Windows 8.1",       "Windows 8.1", 4, [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
            new(OS_FAMILY.WINDOWS, "Windows 10",        "Windows 10", 4, [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64, PC_TYPE.AARCH64], []),
            new(OS_FAMILY.WINDOWS, "Windows 11",        "Windows 11", 5, [true, true], [PC_TYPE.X86_64, PC_TYPE.AARCH64], []),
            new(OS_FAMILY.WINDOWS, "Generic Windows",   "Generic Windows", 5, [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),

            new(OS_FAMILY.MACOS, "System Software 1-6",                     6, [true, false], PC_TYPE.M68K, ["Mac System Software 1.X", "Mac System Software 2.X", "Mac System Software 3.X", "Mac System Software 4.X", "Mac System Software 5.X", "Mac System Software 6.X"]),
            new(OS_FAMILY.MACOS, "MacOS 7",                                 6, [true, false], PC_TYPE.PPC, []),
            new(OS_FAMILY.MACOS, "MacOS 8",                                 6, [true, false], PC_TYPE.PPC, []),
            new(OS_FAMILY.MACOS, "MacOS 10.0",          "Mac OS X 10.0 Cheetah", 7, [true, false], [PC_TYPE.PPC], []),
            new(OS_FAMILY.MACOS, "MacOS 10.1",          "Mac OS X 10.1 Puma", 7, [true, false], [PC_TYPE.PPC], []),
            new(OS_FAMILY.MACOS, "MacOS 10.2",          "Mac OS X 10.2 Jaguar", 7, [true, true], [PC_TYPE.PPC], []),
            new(OS_FAMILY.MACOS, "MacOS 10.3",          "Mac OS X 10.3 Panther", 7, [true, true], [PC_TYPE.PPC], []),
            new(OS_FAMILY.MACOS, "MacOS 10.4",          "Mac OS X 10.4 Tiger", 7, [true, true], [PC_TYPE.PPC, PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "MacOS 10.5",          "Mac OS X 10.5 Leopard", 7, [true, true], [PC_TYPE.PPC, PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "MacOS 10.6",          "Mac OS X 10.6 Snow Leopard", 7, [true, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "MacOS 10.7",          "Mac OS X 10.7 Lion", 7, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "MacOS 10.8",          "OSX 10.8 Mountain Lion", 7, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "MacOS 10.9",          "OSX 10.9 Mavericks", 7, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "MacOS 10.10",         "OSX 10.10 Yosemite", 7, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "MacOS 10.11",         "OSX 10.11 El Capitan", 7, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "macOS 10.12",         "macOS 10.12 Sierra", 8, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "macOS 10.13",         "macOS 10.13 High Sierra", 8, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "macOS 10.14",         "macOS 10.14 Mojave", 8, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "macOS 10.15",         "macOS 10.15 Catalina", 8, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "macOS 11",            "macOS 11 Big Sur", 8, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "macOS 12",            "macOS 12 Monterey", 8, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "macOS 13",            "macOS 13 Ventura", 8, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "macOS 14",            "macOS 14 Sonoma", 8, [false, true], [PC_TYPE.X86_64], []),
            new(OS_FAMILY.MACOS, "macOS 15",            "macOS 15 Sequoia", 8, [false, true], [PC_TYPE.X86_64], []),

            new(OS_FAMILY.LINUX, "Generic Linux",       "Generic Linux", 9, [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
            new(OS_FAMILY.LINUX, "Walter White",        "ME WHEN RYAN GOSLING!!!", 10, [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
        ];

        public static List<OperatingSystem> getFamily(OS_FAMILY family)
        {
            loadSystems();
            return [.. allSystems.Where(os => os.Family == family)];
        }

        public static bool getCompatability(OperatingSystem system, PC_TYPE type) => system.Compatability.Contains(type);

        public static bool anyInFamilyCompatability(OS_FAMILY family, PC_TYPE type) => getFamily(family).Any(os => getCompatability(os, type));

        public static string[] getNamesFromFamily(OS_FAMILY family) => [.. getFamily(family).Select(os => os.Name)];

        public static string[] getFriendlyNamesFromFamily(OS_FAMILY family) => [.. getFamily(family).Select(os => os.FriendlyName)];

        public static string[] getFriendlyNamesFromFamilyWithCompatability(OS_FAMILY family, PC_TYPE type) => [.. getFamily(family).Where(os => getCompatability(os, type)).Select(os => os.FriendlyName)];

        public static OperatingSystem get(string name)
        {
            loadSystems();
            return allSystems.First(os => os.Name == name);
        }

        public static OperatingSystem getByFriendlyName(string friendlyName)
        {
            loadSystems();
            return allSystems.First(os => os.FriendlyName == friendlyName);
        }
    }
}

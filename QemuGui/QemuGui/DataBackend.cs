using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace QEMUInterface
{
    internal enum OS_FAMILY
    {
        WINDOWS,
        MACOS,
        LINUX,
        OTHER
    }

    internal enum PC_TYPE
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

    internal readonly struct OperatingSystem
    {
        public readonly OS_FAMILY Family;
        public readonly string Name;
        public readonly string FriendlyName;
        public readonly bool[] Bitness; // [32, 64]
        public readonly PC_TYPE[] Compatability;
        public readonly string[] MinorVers; // TODO: convert this to operating system array of minor versions

        public OperatingSystem(OS_FAMILY family, string name, string friendlyName, bool[] bitness, PC_TYPE[] compatability, string[] minorVers)
        {
            Family = family;
            Name = name;
            FriendlyName = friendlyName;
            Bitness = bitness;
            Compatability = compatability;
            MinorVers = minorVers;
        }

        public OperatingSystem(OS_FAMILY family, string name, bool[] bitness, PC_TYPE compatability, string[] minorVers)
        {
            Family = family;
            Name = name;
            FriendlyName = name;
            Bitness = bitness;
            Compatability = [compatability];
            MinorVers = minorVers;
        }

    }

    // this code sucks because why does it just waste so much memory
    internal static class OperatingSystems
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        private static List<OperatingSystem> allSystems;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

        private static void loadSystems() => allSystems ??= new List<OperatingSystem>
            {
                new(OS_FAMILY.WINDOWS, "Windows XP",        "Windows XP", [true, false], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
                new(OS_FAMILY.WINDOWS, "Windows Vista",     "Windows Vista", [true, false], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
                new(OS_FAMILY.WINDOWS, "Windows 7",         "Windows 7", [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
                new(OS_FAMILY.WINDOWS, "Windows 8",         "Windows 8", [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
                new(OS_FAMILY.WINDOWS, "Windows 8.1",       "Windows 8.1", [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
                new(OS_FAMILY.WINDOWS, "Windows 10",        "Windows 10", [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
                new(OS_FAMILY.WINDOWS, "Windows 11",        "Windows 11", [true, true], [PC_TYPE.X86_64, PC_TYPE.AARCH64], []),
                new(OS_FAMILY.WINDOWS, "Generic Windows",   "Generic Windows", [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),

                new(OS_FAMILY.MACOS, "System Software 0-6", [true, false], PC_TYPE.M68K, ["Mac System Software 1.X", "Mac System Software 2.X", "Mac System Software 3.X", "Mac System Software 4.X", "Mac System Software 5.X", "Mac System Software 6.X"]),
                new(OS_FAMILY.MACOS, "MacOS 7", [true, false], PC_TYPE.PPC, []),
                new(OS_FAMILY.MACOS, "MacOS 10.0",          "Mac OSX 10.0 Cheetah", [true, false], [PC_TYPE.PPC], []),
                new(OS_FAMILY.MACOS, "MacOS 10.1",          "Mac OSX 10.1 Puma", [true, false], [PC_TYPE.PPC], []),
                new(OS_FAMILY.MACOS, "MacOS 10.2",          "Mac OSX 10.2 Jaguar", [true, true], [PC_TYPE.PPC], []),
                new(OS_FAMILY.MACOS, "MacOS 10.3",          "Mac OSX 10.3 Panther", [true, true], [PC_TYPE.PPC], []),
                new(OS_FAMILY.MACOS, "MacOS 10.4",          "Mac OSX 10.4 Tiger", [true, true], [PC_TYPE.PPC, PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "MacOS 10.5",          "Mac OSX 10.5 Leopard", [true, true], [PC_TYPE.PPC, PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "MacOS 10.6",          "Mac OSX 10.6 Snow Leopard", [true, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "MacOS 10.7",          "Mac OSX 10.7 Lion", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "MacOS 10.8",          "Mac OSX 10.8 Mountain Lion", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "MacOS 10.9",          "Mac OSX 10.9 Mavericks", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "MacOS 10.10",         "Mac OSX 10.10 Yosemite", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "MacOS 10.11",         "Mac OSX 10.11 El Capitan", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "macOS 10.12",         "macOS 10.12 Sierra", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "macOS 10.13",         "macOS 10.13 High Sierra", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "macOS 10.14",         "macOS 10.14 Mojave", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "macOS 10.15",         "macOS 10.15 Catalina", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "macOS 11",            "macOS 11 Big Sur", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "macOS 12",            "macOS 12 Monterey", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "macOS 13",            "macOS 13 Ventura", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "macOS 14",            "macOS 14 Sonoma", [false, true], [PC_TYPE.X86_64], []),
                new(OS_FAMILY.MACOS, "macOS 15",            "macOS 15 Sequoia", [false, true], [PC_TYPE.X86_64], []),

                new(OS_FAMILY.LINUX, "Generic Linux",       "Generic Linux", [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []),
            };

        public static string[] getFamilies() => Enum.GetNames(typeof(OS_FAMILY));

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

        //public static void dumpMem()
        //{
        //    allSystems.Clear();
        //}
    }
}

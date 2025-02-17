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
        public readonly bool[] bitness; // [32, 64]
        public readonly PC_TYPE[] Compatability;
        public readonly string[] MinorVers;

        public OperatingSystem(OS_FAMILY family, string name, string friendlyName, bool[] bitness, PC_TYPE[] compatability, string[] minorVers)
        {
            Family = family;
            Name = name;
            FriendlyName = friendlyName;
            this.bitness = bitness;
            Compatability = compatability;
            MinorVers = minorVers;
        }

        public OperatingSystem(OS_FAMILY family, string name, bool[] bitness, PC_TYPE compatability, string[] minorVers)
        {
            Family = family;
            Name = name;
            FriendlyName = name;
            this.bitness = bitness;
            Compatability = [compatability];
            MinorVers = minorVers;
        }

    }

    // this code sucks because why does it just waste so much memory
    internal static class OperatingSystems
    {
        public static readonly OperatingSystem WINDOWS_XP = new(OS_FAMILY.WINDOWS, "Windows XP", "Windows XP", [true, false], [PC_TYPE.IA_32, PC_TYPE.X86_64], []);
        public static readonly OperatingSystem WINDOWS_VISTA = new(OS_FAMILY.WINDOWS, "Windows Vista", "Windows Vista", [true, false], [PC_TYPE.IA_32, PC_TYPE.X86_64], []);
        public static readonly OperatingSystem WINDOWS_7 = new(OS_FAMILY.WINDOWS, "Windows 7", "Windows 7", [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []);
        public static readonly OperatingSystem WINDOWS_8 = new(OS_FAMILY.WINDOWS, "Windows 8", "Windows 8", [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []);
        public static readonly OperatingSystem WINDOWS_8_1 = new(OS_FAMILY.WINDOWS, "Windows 8.1", "Windows 8.1", [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []);
        public static readonly OperatingSystem WINDOWS_10 = new(OS_FAMILY.WINDOWS, "Windows 10", "Windows 10", [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []);
        public static readonly OperatingSystem WINDOWS_11 = new(OS_FAMILY.WINDOWS, "Windows 11", "Windows 11", [true, true], [PC_TYPE.X86_64, PC_TYPE.AARCH64], []);
        public static readonly OperatingSystem WINDOWS_GENERIC = new(OS_FAMILY.WINDOWS, "Generic Windows", "Generic Windows", [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []);


        public static readonly OperatingSystem MAC_SYSTEM_SOFTWARE_0_6 = new(OS_FAMILY.MACOS, "System Software 0-6", [true, false], PC_TYPE.M68K, ["Mac System Software 1.X", "Mac System Software 2.X", "Mac System Software 3.X", "Mac System Software 4.X", "Mac System Software 5.X", "Mac System Software 6.X"]);
        public static readonly OperatingSystem MAC_7 = new(OS_FAMILY.MACOS, "MacOS 7", [true, false], PC_TYPE.PPC, []);
        public static readonly OperatingSystem OSX_0 = new(OS_FAMILY.MACOS, "MacOS 10.0", "Mac OSX 10.0 Cheetah", [true, false], [PC_TYPE.PPC], []);
        public static readonly OperatingSystem OSX_1 = new(OS_FAMILY.MACOS, "MacOS 10.1", "Mac OSX 10.1 Puma", [true, false], [PC_TYPE.PPC], []);
        public static readonly OperatingSystem OSX_2 = new(OS_FAMILY.MACOS, "MacOS 10.2", "Mac OSX 10.2 Jaguar", [true, true], [PC_TYPE.PPC], []);
        public static readonly OperatingSystem OSX_3 = new(OS_FAMILY.MACOS, "MacOS 10.3", "Mac OSX 10.3 Panther", [true, true], [PC_TYPE.PPC], []);
        public static readonly OperatingSystem OSX_4 = new(OS_FAMILY.MACOS, "MacOS 10.4", "Mac OSX 10.4 Tiger", [true, true], [PC_TYPE.PPC, PC_TYPE.X86_64], []);
        public static readonly OperatingSystem OSX_5 = new(OS_FAMILY.MACOS, "MacOS 10.5", "Mac OSX 10.5 Leopard", [true, true], [PC_TYPE.PPC, PC_TYPE.X86_64], []);
        public static readonly OperatingSystem OSX_6 = new(OS_FAMILY.MACOS, "MacOS 10.6", "Mac OSX 10.6 Snow Leopard", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem OSX_7 = new(OS_FAMILY.MACOS, "MacOS 10.7", "Mac OSX 10.7 Lion", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem OSX_8 = new(OS_FAMILY.MACOS, "MacOS 10.8", "Mac OSX 10.8 Mountain Lion", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem OSX_9 = new(OS_FAMILY.MACOS, "MacOS 10.9", "Mac OSX 10.9 Mavericks", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem OSX_10 = new(OS_FAMILY.MACOS, "MacOS 10.10", "Mac OSX 10.10 Yosemite", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem OSX_11 = new(OS_FAMILY.MACOS, "MacOS 10.11", "Mac OSX 10.11 El Capitan", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem MACOS_SIERRA = new(OS_FAMILY.MACOS, "macOS 10.12", "macOS 10.12 Sierra", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem MACOS_HIGHSIERRA = new(OS_FAMILY.MACOS, "macOS 10.13", "macOS 10.13 High Sierra", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem MACOS_MOJAVE = new(OS_FAMILY.MACOS, "macOS 10.14", "macOS 10.14 Mojave", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem MACOS_CATALINA = new(OS_FAMILY.MACOS, "macOS 10.15", "macOS 10.15 Catalina", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem MACOS_BIGSUR = new(OS_FAMILY.MACOS, "macOS 11", "macOS 11 Big Sur", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem MACOS_MONTEREY = new(OS_FAMILY.MACOS, "macOS 12", "macOS 12 Monterey", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem MACOS_VENTURA = new(OS_FAMILY.MACOS, "macOS 13", "macOS 13 Ventura", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem MACOS_SONOMA = new(OS_FAMILY.MACOS, "macOS 14", "macOS 14 Sonoma", [true, true], [PC_TYPE.X86_64], []);
        public static readonly OperatingSystem MACOS_SEQUOIA = new(OS_FAMILY.MACOS, "macOS 15", "macOS 15 Sequoia", [true, true], [PC_TYPE.X86_64], []);
 
        public static readonly OperatingSystem LINUX_GENERIC = new(OS_FAMILY.LINUX, "Generic Linux", "Generic Linux", [true, true], [PC_TYPE.IA_32, PC_TYPE.X86_64], []);

        private static List<OperatingSystem> allSystems;

        private static void parseSystems() => allSystems ??= new List<OperatingSystem>
            {
                WINDOWS_XP,
                WINDOWS_VISTA,
                WINDOWS_7,
                WINDOWS_8,
                WINDOWS_8_1,
                WINDOWS_10,
                WINDOWS_11,
                WINDOWS_GENERIC,
                MAC_SYSTEM_SOFTWARE_0_6,
                MAC_7,
                OSX_0,
                OSX_1,
                OSX_2,
                OSX_3,
                OSX_4,
                OSX_5,
                OSX_6,
                OSX_7,
                OSX_8,
                OSX_9,
                OSX_10,
                OSX_11,
                MACOS_SIERRA,
                MACOS_HIGHSIERRA,
                MACOS_MOJAVE,
                MACOS_CATALINA,
                MACOS_BIGSUR,
                MACOS_MONTEREY,
                MACOS_VENTURA,
                MACOS_SONOMA,
                MACOS_SEQUOIA,
                LINUX_GENERIC
            };

        public static string[] getFamilies() => Enum.GetNames(typeof(OS_FAMILY));

        public static List<OperatingSystem> getFamily(OS_FAMILY family)
        {
            parseSystems();
            return allSystems.Where(os => os.Family == family).ToList();
        }

        public static bool getCompatability(OperatingSystem system, PC_TYPE type) => system.Compatability.Contains(type);

        public static bool anyInFamilyCompatability(OS_FAMILY family, PC_TYPE type) => getFamily(family).Any(os => getCompatability(os, type));

        public static string[] getNamesFromFamily(OS_FAMILY family) => getFamily(family).Select(os => os.Name).ToArray();

        public static string[] getFriendlyNamesFromFamily(OS_FAMILY family) => getFamily(family).Select(os => os.FriendlyName).ToArray();

        public static OperatingSystem get(string name)
        {
            parseSystems();
            return allSystems.First(os => os.Name == name);
        }
    }
}

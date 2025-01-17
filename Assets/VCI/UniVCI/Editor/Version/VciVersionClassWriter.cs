﻿using System.IO;

namespace VCI
{
    internal static class VciVersionClassWriter
    {
        private const string FilePath = "Assets/VCI/UniVCI/Scripts/Format/VCIVersion.cs";

        public static void Write(int majorVersion, int minorVersion, int patchVersion)
        {
            File.WriteAllText(FilePath, GenerateFileText(majorVersion, minorVersion, patchVersion));
        }

        private static string GenerateFileText(int majorVersion, int minorVersion, int patchVersion)
        {
            return $@"//
// NOTE: Don't modify.
//       This file is generated by '{nameof(VciVersionClassWriter)}' class.
//
namespace VCI
{{
    public static class VCIVersion
    {{
        public const string VCI_VERSION = ""UniVCI-"" + VERSION;

        public const int MAJOR = {majorVersion};
        public const int MINOR = {minorVersion};
        public const int PATCH = {patchVersion};

        public const string VERSION = ""{majorVersion}.{minorVersion}"";
        public const string PATCH_NUMBER = ""{patchVersion}"";
    }}
}}
";
        }
    }
}

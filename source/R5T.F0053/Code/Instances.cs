using System;

using R5T.F0054;


namespace R5T.F0053
{
    public static class Instances
    {
        public static Z0072.Z000.IFileExtensions FileExtensions => Z0072.Z000.FileExtensions.Instance;
        public static ITextFileGenerator TextFileGenerator { get; } = F0054.TextFileGenerator.Instance;
    }
}
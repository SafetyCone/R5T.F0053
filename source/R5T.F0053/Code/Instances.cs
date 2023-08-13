using System;

using R5T.F0054;


namespace R5T.F0053
{
    public static class Instances
    {
        public static IFileExtensions FileExtensions => F0053.FileExtensions.Instance;
        public static ITextFileGenerator TextFileGenerator { get; } = F0054.TextFileGenerator.Instance;
    }
}
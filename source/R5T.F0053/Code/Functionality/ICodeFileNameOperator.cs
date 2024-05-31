using System;

using R5T.T0132;


namespace R5T.F0053
{
	[FunctionalityMarker]
	public partial interface ICodeFileNameOperator : IFunctionalityMarker
	{
        /// <summary>
        /// Whatever the input file name, append the CSharp code file extension (and file extension separator).
        /// </summary>
        public string Append_CSharpFileExtension(string fileName)
        {
            var output = $"{fileName}.{Instances.FileExtensions.cs}";
            return output;
        }

        public string GetCSharpCodeFileName_ForTypeName(
            string typeName)
        {
            // Just use the type name directly, assuming it only contains valid characters.
            var output = $"{typeName}.{Instances.FileExtensions.cs}";
            return output;
        }

        public string GetWindowsFormClassFileName(
            string formName)
        {
            var output = this.GetCSharpCodeFileName_ForTypeName(formName);
            return output;
        }

        public string GetWindowsFormDesignerFileName(
            string formName)
        {
            var output = $"{formName}.{FileNameAffixes.Instance.Designer}.{Instances.FileExtensions.cs}";
            return output;
        }

        public string GetWindowsFormResxFileName(
            string formName)
        {
            var output = $"{formName}.{Instances.FileExtensions.resx}";
            return output;
        }
    }
}
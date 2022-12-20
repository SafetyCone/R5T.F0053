using System;

using R5T.T0132;


namespace R5T.F0053
{
	[FunctionalityMarker]
	public partial interface ICodeFileNameOperator : IFunctionalityMarker
	{
        public string GetCSharpCodeFileName_ForTypeName(
            string typeName)
        {
            // Just use the type name directly, assuming it only contains valid characters.
            var output = $"{typeName}.{FileExtensions.Instance.cs}";
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
            var output = $"{formName}.{FileNameAffixes.Instance.Designer}.{FileExtensions.Instance.cs}";
            return output;
        }

        public string GetWindowsFormResxFileName(
            string formName)
        {
            var output = $"{formName}.{FileExtensions.Instance.Resx}";
            return output;
        }
    }
}
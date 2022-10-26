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
    }
}
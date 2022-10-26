using System;

using R5T.T0131;


namespace R5T.F0053
{
	[ValuesMarker]
	public partial interface IFileExtensions : IValuesMarker
	{
#pragma warning disable IDE1006 // Naming Styles

        public string cs => "cs";

#pragma warning restore IDE1006 // Naming Styles


        public string CSharpCodeFile => this.cs;
	}
}
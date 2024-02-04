using System;


namespace R5T.F0053
{
	public class CodeFileGenerator : ICodeFileGenerator
	{
		#region Infrastructure

	    public static ICodeFileGenerator Instance { get; } = new CodeFileGenerator();

	    private CodeFileGenerator()
	    {
        }

	    #endregion
	}
}
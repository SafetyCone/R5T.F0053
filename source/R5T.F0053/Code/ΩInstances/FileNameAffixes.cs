using System;


namespace R5T.F0053
{
    public class FileNameAffixes : IFileNameAffixes
    {
        #region Infrastructure

        public static IFileNameAffixes Instance { get; } = new FileNameAffixes();


        private FileNameAffixes()
        {
        }

        #endregion
    }
}

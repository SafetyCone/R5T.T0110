using System;


namespace R5T.T0110
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class LibraryName : ILibraryName
    {
        #region Static
        
        public static LibraryName Instance { get; } = new();

        #endregion
    }
}
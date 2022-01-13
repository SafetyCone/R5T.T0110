using System;


namespace R5T.T0110
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class LibraryDescription : ILibraryDescription
    {
        #region Static
        
        public static LibraryDescription Instance { get; } = new();

        #endregion
    }
}
using System;


namespace R5T.T0110
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class LibraryNameOperator : ILibraryNameOperator
    {
        #region Static
        
        public static LibraryNameOperator Instance { get; } = new();

        #endregion
    }
}
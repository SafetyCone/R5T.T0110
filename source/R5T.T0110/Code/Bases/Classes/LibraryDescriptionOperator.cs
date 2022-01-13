using System;


namespace R5T.T0110
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class LibraryDescriptionOperator : ILibraryDescriptionOperator
    {
        #region Static
        
        public static LibraryDescriptionOperator Instance { get; } = new();

        #endregion
    }
}
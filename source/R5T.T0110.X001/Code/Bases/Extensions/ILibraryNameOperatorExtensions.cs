using System;

using R5T.T0110;


namespace System
{
    public static class ILibraryNameOperatorExtensions
    {
        /// <summary>
        /// The default library name is just the solution name.
        /// </summary>
        public static string GetLibraryNameFromSolutionName(this ILibraryNameOperator _,
            string solutionName)
        {
            // The default library name is just the solution name.
            return solutionName;
        }

        /// <summary>
        /// The default project name is just the library name.
        /// </summary>
        public static string GetProjectName(this ILibraryNameOperator _,
            string libraryName)
        {
            // The default project name is just the library name.
            var projectName = libraryName;
            return projectName;
        }

        /// <summary>
        /// The default project name stem is just the library name.
        /// </summary>
        public static string GetProjectNameStem(this ILibraryNameOperator _,
            string libraryName)
        {
            // The default project name stem is just the library name.
            var projectNameStem = libraryName;
            return projectNameStem;
        }

        /// <summary>
        /// The default repository name is just the library name.
        /// </summary>
        public static string GetRepositoryName(this ILibraryNameOperator _,
            string libraryName)
        {
            // The default repository name is just the library name.
            var repositoryName = libraryName;
            return repositoryName;
        }

        /// <summary>
        /// The default solution name is just the library name.
        /// </summary>
        public static string GetSolutionName(this ILibraryNameOperator _,
            string libraryName)
        {
            // The default solution name is just the library name.
            var solutionName = libraryName;
            return solutionName;
        }

        /// <summary>
        /// The default solution name is just the library name.
        /// </summary>
        public static string GetSolutionNameStem(this ILibraryNameOperator _,
            string libraryName)
        {
            // The default solution name is just the library name.
            var solutionName = libraryName;
            return solutionName;
        }
    }
}
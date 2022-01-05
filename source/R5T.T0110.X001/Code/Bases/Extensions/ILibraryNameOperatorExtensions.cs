using System;

using R5T.T0110;


namespace System
{
    public static class ILibraryNameOperatorExtensions
    {
        public static string GetLibraryNameFromSolutionName(this ILibraryNameOperator _,
            string solutionName)
        {
            // The library name is just the solution name.
            return solutionName;
        }

        public static string GetProjectName(this ILibraryNameOperator _,
            string libraryName)
        {
            // The project name is just the library name.
            var projectName = libraryName;
            return projectName;
        }

        public static string GetProjectNameStem(this ILibraryNameOperator _,
            string libraryName)
        {
            // The project name stem is just the library name.
            var projectNameStem = libraryName;
            return projectNameStem;
        }

        public static string GetRepositoryName(this ILibraryNameOperator _,
            string libraryName)
        {
            // The repository name is just the library name.
            var repositoryName = libraryName;
            return repositoryName;
        }

        public static string GetSolutionName(this ILibraryNameOperator _,
            string libraryName)
        {
            // The solution name is just the library name.
            var solutionName = libraryName;
            return solutionName;
        }

        public static string GetSolutionNameStem(this ILibraryNameOperator _,
            string libraryName)
        {
            // The solution name is just the library name.
            var solutionName = libraryName;
            return solutionName;
        }
    }
}
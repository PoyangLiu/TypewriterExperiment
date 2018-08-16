using System;

namespace MyApp
{
    /// <summary>
    /// Marks C# (enum|class|interface) for export with the Typewriter Visual Studio extension.
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Enum |
        AttributeTargets.Class |
        AttributeTargets.Interface
    )]
    public class ExportToTypescriptAttribute : Attribute
    {
    }
}

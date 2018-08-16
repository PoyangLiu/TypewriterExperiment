using System.Linq;
using Typewriter.CodeModel;

namespace MyTypewriterHelper
{
    // Bug: Unfortunately we cannot extend existing TypeWriter.CodeModel classes.
    public static partial class TypewriterHelper
    {
        public static string ExportToTypescriptAttributeName = "ExportToTypescript";

        public static bool HasExportToTypeScriptAttribute(dynamic item /* class | Enum | Interface */)
        {
            if (item.Attributes == null) return false;
            var attributes = (AttributeCollection) item.Attributes;
            return attributes.Any(attr => attr.Name == ExportToTypescriptAttributeName);
        }

    }

}

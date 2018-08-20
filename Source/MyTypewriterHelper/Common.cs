using System.Linq;

namespace Typewriter.CodeModel
{
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

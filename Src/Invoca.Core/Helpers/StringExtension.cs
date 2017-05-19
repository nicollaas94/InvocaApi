using System.Linq;

namespace Invoca.Core.Helpers
{
    internal static class StringExtension
    {
        internal static string SnakeCase(this string clrPropertyName)
        {
            return string.Concat(clrPropertyName.Select((x, i) => ( i==0? char.ToLower(x).ToString(): (char.IsUpper(x) ? "_" + char.ToLower(x).ToString() : x.ToString()) ) ));
        }
    }
}

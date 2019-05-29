using System.IO;

namespace StorageHolder.Misc
{
    public static class Extensions
    {
        public static string PathCombine(this string[] paths)
        {
            string result = string.Empty;
            foreach (string path in paths)
                result = Path.Combine(result, path);
            return result;
        }
    }
}

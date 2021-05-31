using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FolderCreatorApplication
{
    public static class StringExtension
    {
        public static bool IsExistentFolderPath(this string @string)
        {
            return Directory.Exists(@string);
        }

        public static bool IsValidFolderPath(this string @string)
        {
            try
            {
                Path.GetFullPath(@string);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

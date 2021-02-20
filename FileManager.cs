using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ejercisiosBasicos
{
    public static class FileManager
    {
        public static bool FileValidationExist(string pFileRoute)
        {
            bool exist = false;

            if (File.Exists(pFileRoute))
            {
                exist = true;
            }
            return exist;
        }

        public static bool FileValidationFormat(string pFileRoute, string[] pFormatSuported)
        {
            bool validFormat = false;

            string fileExt = pFileRoute.Substring(pFileRoute.Length - 4, 4);

            foreach (string validExt in pFormatSuported)
            {
                if (fileExt == validExt)
                {
                    validFormat = true;
                    break;
                }
            }
            return validFormat;
        }
    }
}

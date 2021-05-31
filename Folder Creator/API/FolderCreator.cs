using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using FolderCreatorApplication.Properties;

namespace FolderCreatorApplication
{
    public class FolderCreator
    {
        public string TargetFolderPath
        {
            get
            {
                return Settings.Default.TargetFolderPath;
            }
            set
            {
                Settings.Default.TargetFolderPath = value;
                Settings.Default.Save();
            }
        }
        public string CommonFolderName { get; set; }
        public int RangeStart { get; set; }
        public int RangeEnd { get; set; }
        public int FoldersCount
        {
            get
            {
                if (RangeStart > RangeEnd)
                {
                    return 0;
                }
                return (RangeEnd - RangeStart + 1);
            }
        }
        public bool HasValidData
        {
            get
            {
                return TargetFolderPath.IsExistentFolderPath()
                    && CommonFolderName.IsValidFolderPath()
                    && (RangeStart <= RangeEnd);
            }
        }

        public FolderCreator(string targetFolderPath = "", string commonFolderName = "",
            int rangeStart = 0, int rangeEnd = 0)
        {
            this.TargetFolderPath = targetFolderPath == ""
                ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : targetFolderPath;
            this.CommonFolderName = commonFolderName == ""
                ? "New Folder " : commonFolderName;
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        public string GetFolderName(int index)
        {
            return string.Format("{0}{1}", CommonFolderName.TrimStart(), index);
        }

        public void CreateFolders()
        {
            if (!TargetFolderPath.IsExistentFolderPath())
            {
                throw new InvalidDataException("Invalid target folder.");
            }

            if (!CommonFolderName.IsValidFolderPath())
            {
                throw new InvalidDataException("Invalid common folder name.");
            }

            if (RangeStart > RangeEnd)
            {
                throw new InvalidDataException("Invalid numeric range.");
            }


            for (int i = RangeStart; i <= RangeEnd; i++)
            {
                string folderPath = Path.Combine(TargetFolderPath, GetFolderName(i));
                if (folderPath.IsExistentFolderPath())
                {
                    string message = string.Format("Folder \"{0}\" already exists.", folderPath);
                    throw new InvalidOperationException(message);
                }
                Directory.CreateDirectory(folderPath);
            }
        }
    }
}

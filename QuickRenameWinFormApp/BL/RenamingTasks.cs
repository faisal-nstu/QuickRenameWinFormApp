using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRenameWinFormApp.BL
{
    public static class RenamingTasks
    {
        public static void Rename(List<string> fileList, string newName)
        {
            int increment = 0;
            string replacer = newName;
            string replaceable, filePath, _newFileName;
            if (fileList.Count == 1)
            {
                foreach (var file in fileList)
                {
                    replaceable = System.IO.Path.GetFileNameWithoutExtension(file);
                    _newFileName = file.Replace(replaceable, replacer);
                    System.IO.File.Move(file, _newFileName);
                }
            }
            else
            {
                foreach (var file in fileList)
                {
                    replaceable = System.IO.Path.GetFileNameWithoutExtension(file);
                    _newFileName = file.Replace(replaceable, (replacer + " - " + (++increment)));
                    System.IO.File.Move(file, _newFileName);
                }
            }
        }

        public static void Prepend(List<string> fileList, string newName)
        {
            string replacer = newName;
            string replaceable, _newFileName;
            foreach (var file in fileList)
            {
                replaceable = System.IO.Path.GetFileNameWithoutExtension(file);
                _newFileName = file.Replace(replaceable, (replacer + replaceable));
                System.IO.File.Move(file, _newFileName);
            }
        }

        public static void Append(List<string> fileList, string newName)
        {
            string replacer = newName;
            string replaceable, _newFileName;
            foreach (var file in fileList)
            {
                replaceable = System.IO.Path.GetFileNameWithoutExtension(file);
                _newFileName = file.Replace(replaceable, (replaceable + replacer));
                System.IO.File.Move(file, _newFileName);
            }
        }

        public static void ChangeExtension(List<string> fileList, string newName)
        {
            string newExtension = newName;
            foreach (var file in fileList)
            {
                System.IO.File.Move(file, System.IO.Path.ChangeExtension(file, ("." + newExtension)));
            }
        }

        public static void Replace(List<string> fileList,string replaceableText ,string replacer)
        {
            string _newFileName;
            foreach (var file in fileList)
            {
                _newFileName = file.Replace(replaceableText, replacer);
                System.IO.File.Move(file, _newFileName);
            }
        }

        public static void RemoveNumbers(List<string> fileList, string noOfDigitsToRemove)
        {
            string _newFileName;
            foreach (var file in fileList)
            {
                var fileName = Path.GetFileNameWithoutExtension(file);
                var aStringBuilder = new StringBuilder(fileName);
                aStringBuilder.Remove(0,Convert.ToInt32(noOfDigitsToRemove));
                _newFileName = file.Replace(fileName, aStringBuilder.ToString());
                System.IO.File.Move(file, _newFileName);
            }
        }
    }
}

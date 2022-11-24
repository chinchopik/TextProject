using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemakeProject.ViewModels
{
    class FileTextInput
    {

        public static string FileInput()
        {
            string filePath;
            string result ="";
            OpenFileDialog openFileDialog = new();
            openFileDialog.DefaultExt = ".txt";
            openFileDialog.Filter = "Txt files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;

                StreamReader sr = new StreamReader(filePath, Encoding.Default);
                result = sr.ReadToEnd();
                sr.Close();
                
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMD_Xpuct
{
    public static class Library
    {
        /// <summary>
        /// Базовый вызов процесса cmd.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RunCMD(string input)
        {
            string result = string.Empty;
            var psi = new ProcessStartInfo
            {
                FileName = "cmd",
                //Arguments = $"/c chcp 1251 &{input}",
                Arguments = $"/c {input}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            };

            Process process = Process.Start(psi);

            result = process.StandardOutput.ReadToEnd();

            return result;
        }

        public static string RunCMD(string oneArg, string twoArg)
        {
            string result = string.Empty;

            oneArg = oneArg.Replace("\r\n", "");

            var psi = new ProcessStartInfo
            {
                FileName = "cmd",
                //Arguments = $"/c chcp 1251 &{input}",
                Arguments = $"/c chcp 65001 & cd /d {oneArg} {twoArg}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            };

            Process process = Process.Start(psi);

            result = process.StandardOutput.ReadToEnd();

            return result;
        }

        public static string RunCMD(string oneArg, string twoArg, string threeArg)
        {
            string result = string.Empty;

            oneArg = oneArg.Replace("\r\n", "");

            var psi = new ProcessStartInfo
            {
                FileName = "cmd",
                //Arguments = $"/c chcp 1251 &{input}",
                Arguments = $"/c chcp {threeArg} & cd /d {oneArg} & {twoArg}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            };

            Process process = Process.Start(psi);

            result = process.StandardOutput.ReadToEnd();

            return result;
        }

        //public static string ChooseFolder(string path)
        //{

        //    path = path.Replace("\r\n", "");

        //    FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
        //    folderBrowserDialog1.SelectedPath = path;
        //    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        path = folderBrowserDialog1.SelectedPath;
        //    }
        //    return path;
        //}

        public static void OpenDirectory(string path)
        {
            string result = string.Empty;

            path = path.Replace("\r\n", "");

            var psi = new ProcessStartInfo
            {
                FileName = "explorer",
                Arguments = $"{path}"
            };

           Process.Start(psi);


        }
    }
}

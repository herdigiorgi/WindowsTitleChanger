using System;
using System.Diagnostics;

namespace WindowsTitleChanger
{
    class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);

        static void Main(string[] args)
        {
            Console.WriteLine("Windows Title Changer Started");
            Console.WriteLine($"Using config: {ConfigurationReader.CONFIGURATION_FILE_PATH}");
            ConfigurationReader.OpenFileInEditor();
            printConfiguration();
            while (true)
            {
                var titles = ConfigurationReader.ReadConfiguration();
                foreach(var title in titles)
                {
                    Process[] processes = Process.GetProcessesByName(title.ProcessName);
                    foreach(var process  in processes)
                    {
                        SetWindowText(process.MainWindowHandle, title.TargetTitle);
                    }
                }
                System.Threading.Thread.Sleep(500);
            }
        }

        static void printConfiguration()
        {
            var titles = ConfigurationReader.ReadConfiguration();
            foreach(var title in titles)
            {
                Console.WriteLine($"'{title.ProcessName}' -> '{title.TargetTitle}'");
            }
        }
    }
}

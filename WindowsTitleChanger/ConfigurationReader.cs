using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace WindowsTitleChanger
{
    class ConfigurationReader
    {
        private ConfigurationReader(){}

        private static String CONFIGURATION_FILE_NAME = @"config.txt";

        public static void OpenFileInEditor()
        {
            Process.Start("notepad.exe", CONFIGURATION_FILE_NAME);
        }

        public static IEnumerable<TitleConfiguration> ReadConfiguration()
        {
            string[] lines = System.IO.File.ReadAllLines(CONFIGURATION_FILE_NAME);
            var filteredLines = FilterLines(ref lines);
            return CreateConfiguration(filteredLines);
        }

        private static IEnumerable<String> FilterLines(ref string[] lines)
        {
            LinkedList<String> r = new LinkedList<String>();
            foreach(string line in lines)
            {
                var trimedLine = line.Trim();
                if (!trimedLine.StartsWith("#") && trimedLine.Length>0)
                {
                    r.AddLast(line);
                }
            }
            return r;
        }

        private static IEnumerable<TitleConfiguration> CreateConfiguration(IEnumerable<String> lines)
        {
            var r = new LinkedList<TitleConfiguration>();
            var enumerator = lines.GetEnumerator();
            while (true)
            {
                var processName = enumerator.MoveNext() ? enumerator.Current : null;
                var targetTitle = enumerator.MoveNext() ? enumerator.Current : null;
                if (processName == null || targetTitle == null) break;
                r.AddLast(new TitleConfiguration(processName: processName, targetTitle: targetTitle));
            }
            return r;
        }

    }
}

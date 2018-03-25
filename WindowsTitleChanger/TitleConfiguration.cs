using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace WindowsTitleChanger
{
    class TitleConfiguration
    {
        public TitleConfiguration(String processName, String targetTitle)
        {
            this.ProcessName = processName;
            this.TargetTitle = targetTitle;
        }

        public String ProcessName { get; private set; }
        public String TargetTitle { get; private set; }
    }
}

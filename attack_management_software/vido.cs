using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attack_management_software
{
    internal class Video
    {
        public void PlayAttackVideo_f16()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=XXXXX",
                UseShellExecute = true
            });
        }
        public void PlayAttackVideo()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=6LDFD02-Utc",
                UseShellExecute = true
            });
        }
        public void PlayAttackVideo_f15()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.youtube.com/watch?v=cRRMBITl_B8",
                UseShellExecute = true
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace auto_scroll_android
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            ProcessStartInfo info = new ProcessStartInfo("adb.exe");
            info.Arguments = "connect 192.168.1.155";
            info.CreateNoWindow = true;
            info.UseShellExecute = false;
            Process.Start(info);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(checkBox1.CheckState))
            {
                ProcessStartInfo info = new ProcessStartInfo("powershell.exe");
                info.Arguments = "-File autoscroll.ps1";
                info.CreateNoWindow = true;
                info.UseShellExecute = false;
                Process.Start(info);
            }
            else
            {
                foreach (var process in Process.GetProcessesByName("powershell"))
                {
                    process.Kill();
                }
            }
        }
    }
}

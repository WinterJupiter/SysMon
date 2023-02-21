using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SysMon
{
    public partial class Manager : UserControl
    {
        private float CPU;
        private float RAM;
        private ulong memory;

        public Manager()
        {
            InitializeComponent();
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private class MemoryStat
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;

            public MemoryStat()
            {
                this.dwLength = (uint)Marshal.SizeOf(typeof(MemoryStat));
            }
        }

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool GlobalMemoryStatusEx([In, Out] MemoryStat buffer);

        private void Manager_Load(object sender, EventArgs e)
        {
            MemoryStat memstat = new MemoryStat();
            if (GlobalMemoryStatusEx(memstat))
            {
                memory = memstat.ullTotalPhys;
            }

            CPU = 81;
            graph.Series["ЦП"].Points.AddY(CPU);
            graph.Series["ОЗУ"].Points.AddY(RAM);

            label10.Text = Convert.ToString(memory/1000000000) + " Гб";
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            MemoryStat memstat = new MemoryStat();
            if (GlobalMemoryStatusEx(memstat))
            {
                RAM = memstat.dwMemoryLoad;
                label5.Text = Convert.ToString(Math.Round(RAM / 100 * (memory / 1000000000), 1)) + " Гб";
                label9.Text = Convert.ToString(Math.Round((memory / 1000000000 - RAM / 100 * (memory / 1000000000)), 1)) + " Гб";
            }
            CPU = performanceProc.NextValue();

            progressBar1.Value = (int)CPU;
            progressBar2.Value = (int)RAM;
            label2.Text = Convert.ToString(Math.Round(CPU, 1)) + "%";
            label3.Text = Convert.ToString(RAM) + "%";

            if (graph.Series["ЦП"].Points.Count > 14)
            {
                graph.Series["ЦП"].Points.RemoveAt(0);
                graph.Series["ОЗУ"].Points.RemoveAt(0);
            }
            graph.Series["ЦП"].Points.AddY(CPU);
            graph.Series["ОЗУ"].Points.AddY(RAM);
        }
    }
}

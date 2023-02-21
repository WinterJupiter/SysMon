using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;

namespace SysMon
{
    public partial class Temperature : UserControl
    {

        private void GetTemperature()
        {
            string temperature = string.Empty;

            View viewer = new View();
            Computer comp = new Computer();
            comp.Open();
            comp.CPUEnabled = true;
            comp.Accept(viewer);

            for (int i = 0; i < comp.Hardware.Length; i++)
            {
                if (comp.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < comp.Hardware[i].Sensors.Length; j++)
                    {
                        if (comp.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            temperature += comp.Hardware[i].Sensors[j].Name + ": " + comp.Hardware[i].Sensors[j].Value.ToString() + "\n";
                        }
                    }
                }
            }
            richTextBox1.Text = temperature;
            comp.Close();
        }

        public Temperature()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                GetTemperature();
                Thread.Sleep(3000);
            }
        }

        private void Temperature_Load(object sender, EventArgs e)
        {
           backgroundWorker1.RunWorkerAsync();
        }
    }
}

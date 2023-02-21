using System;
using System.Windows.Forms;

namespace SysMon
{

    public partial class body : Form
    {
        static body _obj;

        public body()
        {
            InitializeComponent();
        }

        private void body_Load(object sender, EventArgs e)
        {
            _obj = this;

            Manager manager = new Manager();
            manager.Dock = DockStyle.Fill;
            panelContain.Controls.Add(manager);
            panelContain.Controls["Manager"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manager_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Dock = DockStyle.Fill;
            panelContain.Controls.Add(manager);
            panelContain.Controls["Manager"].BringToFront();
        }

        private void temperature_Click(object sender, EventArgs e)
        {
            Temperature temperature = new Temperature();
            temperature.Dock = DockStyle.Fill;
            panelContain.Controls.Add(temperature);
            panelContain.Controls["Temperature"].BringToFront();
        }

        private void sysinfo_Click(object sender, EventArgs e)
        {
            SysInfo sysinfo = new SysInfo();
            sysinfo.Dock = DockStyle.Fill;
            panelContain.Controls.Add(sysinfo);
            panelContain.Controls["SysInfo"].BringToFront();
        }
    }
}

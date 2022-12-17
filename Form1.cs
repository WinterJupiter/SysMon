using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysMon
{
    public partial class body : Form
    {
        static body _obj;

        public static body Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new body();
                return _obj;
            }
        }

        public Panel PanelContainer
        {
            get
            {
                return panelContain;
            }
            set
            {
                panelContain = value;
            }
        }
        public body()
        {
            InitializeComponent();
        }

        private void body_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

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


        private void panelContain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

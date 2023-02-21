using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenHardwareMonitor.Hardware;

namespace SysMon
{
    internal class View : IVisitor
    {
        public void VisitComputer(IComputer computer)
        {
            computer.Traverse(this);
        }

        public void VisitHardware(IHardware hardware)
        {
            hardware.Update();
            foreach (IHardware HW in hardware.SubHardware)
            {
                HW.Accept(this);
            }
        }

        public void VisitParameter(IParameter parameter)
        {
        }

        public void VisitSensor(ISensor sensor)
        {
        }
    }
}

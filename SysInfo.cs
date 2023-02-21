using System;
using System.Management;
using System.Windows.Forms;

namespace SysMon
{
    public partial class SysInfo : UserControl
    {
        string key = String.Empty;

        public SysInfo()
        {
            InitializeComponent();
            Init();
        }

        private void GetInfo(string key, ListView list)
        {
            list.Items.Clear();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM " + key);

            try
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    ListViewGroup listViewGroup;

                    try
                    {
                        listViewGroup = list.Groups.Add(obj["Name"].ToString(), obj["Name"].ToString());
                    }
                    catch (Exception exception)
                    {
                        listViewGroup = list.Groups.Add(obj.ToString(), obj.ToString());
                    }

                    if (obj.Properties.Count == 0)
                    {
                        MessageBox.Show("Невозможно вывести информацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    foreach (PropertyData data in obj.Properties)
                    {
                        ListViewItem item = new ListViewItem(listViewGroup);

                        item.Text = data.Name;

                        if (data.Value != null && !string.IsNullOrEmpty(data.Value.ToString()))
                        {
                            switch (data.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] stringData = data.Value as string[];
                                    string resStr1 = string.Empty;
                                    foreach (string s in stringData)
                                    {
                                        resStr1 += $"{s} ";
                                    }
                                    item.SubItems.Add(resStr1);
                                    break;

                                case "System.UInt16[]":
                                    ushort[] ushortData = data.Value as ushort[];
                                    string resStr2 = string.Empty;
                                    foreach (ushort us in ushortData)
                                    {
                                        resStr2 += $"{Convert.ToString(us)}";
                                    }
                                    item.SubItems.Add(resStr2);
                                    break;

                                default:
                                    item.SubItems.Add(data.Value.ToString());
                                    break;
                            }

                            list.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Init()
        {
            key = "Win32_Processor";
            GetInfo(key, listView1);
        }

        private void chosebar_Click(object sender, EventArgs e)
        {
           
            switch (chosebar.SelectedItem.ToString())
            {
                case "Процессор":
                    key = "Win32_Processor";
                    break;

                case "Видеокарта":
                    key = "Win32_VideoController";
                    break;

                case "Оперативная память":
                    key = "Win32_PhysicalMemory";
                    break;

                case "Диск":
                    key = "Win32_DiskDrive";
                    break;

                case "Логические диски":
                    key = "Win32_LogicalDisk";
                    break;

                case "Чипсет":
                    key = "Win32_IDEController";
                    break;

                case "Батарея":
                    key = "Win32_Battery";
                    break;

                case "Биос":
                    key = "Win32_BIOS";
                    break;

                case "Кэш":
                    key = "Win32_CacheMemory";
                    break;

                case "USB":
                    key = "Win32_USBController";
                    break;

                case "Клавиатура":
                    key = "Win32_Keyboard";
                    break;

                case "Сеть":
                    key = "Win32_NetworkAdapter";
                    break;

                case "Пользователь":
                    key = "Win32_Account";
                    break;
            }
            GetInfo(key, listView1);
        }
    }
}

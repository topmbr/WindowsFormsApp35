using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveProcessListToFile();
        }
        private void RefreshProcessList()
        {
            processListView.Items.Clear();
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                item.SubItems.Add(process.Threads.Count.ToString());
                item.SubItems.Add(process.HandleCount.ToString());

                processListView.Items.Add(item);
            }
        }
        private void SaveProcessListToFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (ListViewItem item in processListView.Items)
                        {
                            string line = string.Join("\t", item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subItem => subItem.Text));
                            writer.WriteLine(line);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

    }
}

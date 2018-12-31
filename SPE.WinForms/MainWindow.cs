using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPE.WinForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoStuff();
        }

        private void DoStuff()
        {
            if (MainOpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var reader = new System.IO.StreamReader(MainOpenFileDialog.FileName))
                {
                    List<int> lines = new List<int>();
                    while (!reader.EndOfStream)
                    {
                        lines.Add(int.Parse(reader.ReadLine()));
                    }

                    reader.Close();
                }
            }
        }
    }
}

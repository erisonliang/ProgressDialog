using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProgressForms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new ProgressForm(HeavyWork))
            {
                form.ShowDialog();
            }
        }

        private void HeavyWork(IProgress<ProgressReport> progress)
        {
            for(int i = 0; i < 10; i++)
            {
                var list = new List<int>();
                for(int j = 0; j < 100000; j ++)
                {
                    list.Add(j);
                }

                progress.Report(new ProgressReport
                {
                    WorkTitle = "This is Title",
                    MainMessage = "Progress...",
                    Percent = i * 10
                });
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressForms
{
    public partial class ProgressForm : Form
    {
        private IProgress<ProgressReport> _progress;
        private Action<IProgress<ProgressReport>> _doWork;

        public ProgressForm(Action<IProgress<ProgressReport>> doWork)
        {
            InitializeComponent();
            _progress = new Progress<ProgressReport>(SetProgressValue);
            _doWork = doWork;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }

        private void SetProgressValue(ProgressReport report)
        {
            MainMessageLabel.Text = report.MainMessage;
            SubMessageLabel.Text = report.SubMessage;
            ProgressBar.Value = report.Percent;
        }

        private void ProgressForm_Shown(object sender, EventArgs e)
        {
            if (_doWork == null)
                throw new InvalidOperationException("work is nothing.");

            _doWork(_progress);
            MessageBox.Show("Complete.");
        }
    }
}

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
        private Func<IProgress<ProgressReport>, Task> _doWork;

        public ProgressForm(Func<IProgress<ProgressReport>, Task> doWork)
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
            MainMessageLabel.Text = report.MainMessage + report.Percent;
            SubMessageLabel.Text = report.SubMessage;
            ProgressBar.Value = report.Percent;
        }

        private async void ProgressForm_Shown(object sender, EventArgs e)
        {
            if (_doWork == null)
                throw new InvalidOperationException("work is nothing.");

            await _doWork(_progress);
            MessageBox.Show("Complete.");
        }
    }
}

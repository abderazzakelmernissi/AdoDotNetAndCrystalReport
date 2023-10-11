using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class FormTableCroise : Form
    {
        public FormTableCroise()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            EtatTableCroiser et = new EtatTableCroiser();
            crystalReportViewer1.ReportSource = et;
            crystalReportViewer1.Refresh();
        }
    }
}

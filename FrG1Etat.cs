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
    public partial class FrG1Etat : Form
    {
        public FrG1Etat()
        {
            InitializeComponent();
        }

        private void FrG1Etat_Load(object sender, EventArgs e)
        {
            EtatVille EM = new EtatVille();
            crystalReportViewer1.ReportSource = EM;
            crystalReportViewer1.Refresh();
        }
    }
}

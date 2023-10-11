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
    public partial class EtatParVille : Form
    {
        public EtatParVille()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void EtatParVille_Load(object sender, EventArgs e)
        {
            EtatVilleSafi evs = new EtatVilleSafi();
            evs.SetParameterValue("ville","safi");
            crystalReportViewer1.ReportSource = evs;
            crystalReportViewer1.Refresh();
        }
    }
}

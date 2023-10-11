using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class ReportView : Form
    {

        public ReportView()
        {
            InitializeComponent();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            SqlDataReader d;
            Program.cmd.Connection = Program.cn;
            Program.cmd.CommandText = "select distinct VilleMaison from maison ";
            Program.cn.Open();
            d = Program.cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while(d.Read()){

                comboBox1.Items.Add(d[0].ToString());

            }
            Program.cn.Close();
            d.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EtatVilleSafi evs = new EtatVilleSafi();
            evs.SetParameterValue("ville",comboBox1.SelectedItem);
            crystalReportViewer1.ReportSource = evs;
            crystalReportViewer1.Refresh();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlDataReader d;
            Program.cmd.Connection = Program.cn;
            Program.cmd.CommandText = "select distinct VilleMaison from maison ";
            Program.cn.Open();
            d = Program.cmd.ExecuteReader();

            while (d.Read())
            {
                comboBox1.Items.Add(d[0].ToString());

            }
            Program.cn.Close();
            d.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoutMaison evs = new CoutMaison();
            evs.SetParameterValue("ville", comboBox1.SelectedItem);
            evs.SetParameterValue("valeur1", float.Parse(textBox1.Text));
            evs.SetParameterValue("valeur2", float.Parse(textBox2.Text));

            crystalReportViewer1.ReportSource = evs;
            crystalReportViewer1.Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

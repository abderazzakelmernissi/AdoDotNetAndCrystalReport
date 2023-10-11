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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SqlDataReader d;
            Program.cmd.Connection = Program.cn;
            Program.cmd.CommandText = "select NumMaison, AdrMaison from maison ";
            Program.cn.Open();
            d = Program.cmd.ExecuteReader();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            while (d.Read())
            {
                comboBox1.Items.Add(d[0].ToString());
                comboBox2.Items.Add(d[1].ToString());

            }
            Program.cn.Close();
            d.Close();

            Program.cmd.Connection = Program.cn;
            Program.cmd.CommandText = "select NomCabinet from CabinetArchitecte";
            Program.cn.Open();
            d = Program.cmd.ExecuteReader();
            comboBox3.Items.Clear();
            while (d.Read())
            {
                comboBox3.Items.Add(d[0].ToString());

            }
            Program.cn.Close();
            d.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Q5 evs = new Q5();
            evs.SetParameterValue("NumMaison", comboBox1.SelectedItem);
            evs.SetParameterValue("AdrMaison", comboBox2.SelectedItem);
            evs.SetParameterValue("NomCabinet", comboBox3.SelectedItem);

            crystalReportViewer1.ReportSource = evs;
            crystalReportViewer1.Refresh();
        }
    }
}

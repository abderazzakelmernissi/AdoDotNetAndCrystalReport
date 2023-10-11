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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlDataReader d;
            Program.cmd.Connection = Program.cn;
            Program.cmd.CommandType = CommandType.Text;
            Program.cmd.CommandText = " select * from maison ";
            Program.cn.Open();
            d = Program.cmd.ExecuteReader();
          while(d.Read()){
              comboBox1.Items.Add(d[0].ToString() + "/" + d[4].ToString() + "/" + d[1].ToString());
          
        }
            d.Close();
            Program.cn.Close();
            comboBox1.SelectedIndex = 0;
            Program.cmd.Connection = Program.cn;
            Program.cmd.CommandType = CommandType.Text;
            Program.cmd.CommandText = " select * from CabinetArchitecte ";
            Program.cn.Open();
            d = Program.cmd.ExecuteReader();
            while (d.Read())
                comboBox2.Items.Add(d[1].ToString());
            d.Close();
            Program.cn.Close();
            comboBox2.SelectedIndex = 0;
            

            Program.cmd.Connection = Program.cn;
            Program.cmd.CommandType = CommandType.Text;
            Program.cmd.CommandText = " select * from Macon";
            Program.cn.Open();
            d = Program.cmd.ExecuteReader();
            while (d.Read())
                comboBox3.Items.Add(d[1].ToString());
            d.Close();
            Program.cn.Close();

            comboBox3.SelectedIndex = 0;


        }
    }
}

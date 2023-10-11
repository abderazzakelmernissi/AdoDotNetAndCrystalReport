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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            
             if (radioButton1.Checked) { 
                 dataGridView1.Columns.Add("num_maison","numero");
                 dataGridView1.Columns.Add("adr_maison","adress");
                 dataGridView1.Columns.Add("categorie","categorie");
                Program.cmd.Connection= Program.cn;
                SqlDataReader dr;
                dr = Program.cmd.ExecuteReader();
                while (dr.Read()) 
                {
                    dataGridView1.Rows.Add(dr[0], dr[1], dr[2]);
                }
                
                 }
                
       
                
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { 
                
                radioButton1.Checked = false;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("luxe");
                comboBox1.Items.Add("moyenne");
                comboBox1.Items.Add("economique");
                comboBox1.SelectedIndex = 0;
               }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SqlDataReader dr; DataTable dt = new DataTable();
                Program.cmd.Connection = Program.cn;
                Program.cmd.CommandType = CommandType.Text;
                Program.cmd.CommandText = "select * from Maison where VilleMaison ='" + comboBox1.SelectedItem.ToString() + "'";
                Program.cn.Open();
                dr = Program.cmd.ExecuteReader();
                dt.Load(dr);
                Program.cn.Close();
                dr.Close();
                dataGridView1.DataSource = dt;
            }
            else if (radioButton2.Checked) {

                SqlDataReader dr; DataTable dt = new DataTable();
                Program.cmd.Connection = Program.cn;
                Program.cmd.CommandType = CommandType.Text;
                Program.cmd.CommandText = "select * from Maison where Categorie ='" + comboBox1.SelectedItem.ToString() + "'";
                Program.cn.Open();
                dr = Program.cmd.ExecuteReader();
                dt.Load(dr);
                Program.cn.Close();
                dr.Close();
                dataGridView1.DataSource = dt;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

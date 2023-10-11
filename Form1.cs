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
    public partial class Form1 : Form
    {
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        public string nom
        {

            get { return textBox1.Text; }
            set { textBox1.Text = value; }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Program.cmd.Connection = Program.cn;
            Program.cmd.CommandType = CommandType.Text;
            Program.cmd.CommandText = "select count(NumMaison) from Maison";
            Program.cn.Open();
           
            n=(int)Program.cmd.ExecuteScalar();

            Program.cn.Close();
            this.Text = "Gestion des Maison ( "+n.ToString()+" maisons  )"; 
     
            comboBox1.Items.Add("luxe");
            comboBox1.Items.Add("Moyenne");
            comboBox1.Items.Add("Economique");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if(int.Parse(textBox4.Text)>=0){
                Program.cmd.Connection = Program.cn;
                Program.cmd.CommandType = CommandType.StoredProcedure;
                Program.cmd.CommandText = "PAjout";
                Program.cmd.Parameters.Clear();
                Program.cmd.Parameters.AddWithValue("@num_maison", int.Parse(textBox1.Text));
                Program.cmd.Parameters.AddWithValue("@adr_maison", textBox2.Text);
                Program.cmd.Parameters.AddWithValue("@Ville_maison", textBox3.Text);
                Program.cmd.Parameters.AddWithValue("@cout_maison", int.Parse(textBox4.Text));
                Program.cmd.Parameters.AddWithValue("@categorie", comboBox1.SelectedItem.ToString());
                Program.cn.Open();
                Program.cmd.ExecuteNonQuery();
                Program.cn.Close();
                n++;
                this.Text = "Gestion des Maison ( " + n.ToString() + " maisons  )"; 
                }
            }
            catch {
                MessageBox.Show("Error saisie ou Numero existant");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

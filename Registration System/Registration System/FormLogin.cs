using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registration_System
{
    public partial class FormLogin : Form
    {
        private OleDbConnection conn = new OleDbConnection();
        public FormLogin()
        {
            InitializeComponent();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CS LAB\Desktop\FINAL (1)\Sosmena_Data.accdb;Persist Security Info=False;"


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from Information where Username ='" + textUsername.Text + "' and Password ='" + textPass.Text + "'";

                OleDbDataReader or = cmd.ExecuteReader();

                int count = 0;
                while (or.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {

                   
                    this.Hide();
                    
                    StudentINFO cr = new StudentINFO();
                    cr.ShowDialog();


                }
                else
                {

                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();

            }
        }
    }


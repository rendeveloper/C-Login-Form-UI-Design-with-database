using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bunifu.Framework.UI.Drag dr = new Bunifu.Framework.UI.Drag();
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ren\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username ='"+txtuser.Text+"' and password ='"+txtpass.Text+"'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
            this.Hide();
            Main m = new Main();
            m.Show();
            }
            else
            {
                MessageBox.Show("please enter correct username and password", "alert", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

         }

        private void txtuser_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureline_Click(object sender, EventArgs e)
        {

        }

        private void txtpass_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            pictureline.Top = ((Bunifu.Framework.UI.BunifuMetroTextbox)sender).Top + 156;
            panel2.BackColor = SystemColors.ButtonFace;
            txtpass.BackColor = Color.White;
            panel1.BackColor = Color.White;
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            pictureline.Top = ((Bunifu.Framework.UI.BunifuMetroTextbox)sender).Top + 82;
            panel1.BackColor = SystemColors.ButtonFace;
            txtuser.BackColor = Color.White;
            panel2.BackColor = Color.White;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            dr.Release();
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            dr.MoveObject();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            dr.Grab(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

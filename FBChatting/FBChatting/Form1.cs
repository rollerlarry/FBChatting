using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBChatting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }
        string SelectedUser = "";
        int AnimationStep = 0;
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SelectedUser = ((Bunifu.Framework.UI.BunifuFlatButton)sender).ButtonText;
            

            if (((Bunifu.Framework.UI.BunifuFlatButton)sender).ButtonText != SelectedUser)
            {
                slide1.Visible = false;
                slide2.Visible = false;
                slide3.Visible = false;

                lblname.Text = SelectedUser;

                AnimationStep = 0;

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AnimationStep == 0)
            {
                bunifuTransition1.ShowSync(slide1);
                AnimationStep++;
            }
            else if (AnimationStep == 1)
            {
                bunifuTransition2.ShowSync(slide2);
                AnimationStep++;
            }
            else if (AnimationStep == 2)
            {
                bunifuTransition3.ShowSync(slide3);
                AnimationStep = 0;
                //timer1.Stop();
            }
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

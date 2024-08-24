using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace messengerX_v._1._0._0
{
    public partial class SignInWindow : UserControl
    {

        bool showPassword = true;
        public SignInWindow()
        {
            InitializeComponent();
        }

        private void SignInWindow_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            
        }



     
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           foreach(var alltext in panel1.Controls.OfType<MaterialTextBox>())
            {
                alltext.Clear();
            }
        }

        public static string InEmail;
        
        

        public event EventHandler showMessengerWindow;

        private void button1_Click(object sender, EventArgs e)
        {
            InEmail = materialTextBox1.Text;
            Properties.Settings.Default.withSignin = true;
            Properties.Settings.Default.NeedToregister = true;
            Properties.Settings.Default.Save();


            db db_Exist = new db();

            string query = (from i in db_Exist.users where i.Email == materialTextBox1.Text && i.Password == materialTextBox2.Text select i.UserName).Single();
            showMessengerWindow?.Invoke(this, EventArgs.Empty);




            try
            {
               

                
            }
            catch(Exception e1)
            {
                if(e1.Message == "Sequence contains no elements")
                {
                    MessageBox.Show("there is no matching item!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show(e1.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
              
            }
        }

        private void button_password_Click(object sender, EventArgs e)
        {
          
           if(showPassword)
            {
                showPassword = false;
                materialTextBox2.Password = true;
            }

            else
            {
                showPassword = true;
                materialTextBox2.Password = false;
            }

            



        }

        public event EventHandler showRegisterWindow;

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showRegisterWindow?.Invoke(this, EventArgs.Empty); // to invoke this event
        }

       
    }
}

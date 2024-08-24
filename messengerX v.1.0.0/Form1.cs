using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Threading;

namespace messengerX_v._1._0._0
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public void HideEveryComponent()
        {
            foreach(var AllControls in this.Controls.OfType<Control>())
            {
                AllControls.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;

            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }

            this.Text = tmp + this.Text.Trim();

            // Main verse of the program

            bool needToRegister = Properties.Settings.Default.NeedToregister;
            bool needToselecPic = Properties.Settings.Default.needSelectPic;

            if (!needToRegister)
            {
                SignInWindow signInwindow1 = new SignInWindow();
                signInwindow1.Name = "signInWindow1";
                signInwindow1.Dock = DockStyle.Fill;
                signInwindow1.Visible = true;
                signInwindow1.showRegisterWindow += SignInwindow1_showRegisterWindow;
                signInwindow1.showMessengerWindow += SignInwindow1_showMessengerWindow;
             

                this.Controls.Add(signInwindow1);

             
                

            }
            else
            {
                if (needToselecPic)
                {
                    SelectProfilePic selectprofilePic1 = new SelectProfilePic();
                    selectprofilePic1.Name = "selectProfilePic1";
                    selectprofilePic1.Dock = DockStyle.Fill;

                    this.Controls.Add(selectprofilePic1);
                    selectprofilePic1.Visible = true;
                }
                else // it means when the messenger Main page would shown up that the when the need to select pic is false
                {
                    MessengerWindow messengerWindow1 = new MessengerWindow();

                    
                    
                    messengerWindow1.Name = "messengerWindow1";
                    messengerWindow1.Dock = DockStyle.Fill;
                    messengerWindow1.Visible = true;

                    this.Controls.Add(messengerWindow1);
                }
              


            }



        }

        private void SignInwindow1_showMessengerWindow(object sender, EventArgs e)
        {
            foreach (var item in this.Controls.OfType<Control>())
                item.Hide();

            MessengerWindow SignInMessengerWindow = new MessengerWindow();
            SignInMessengerWindow.Name = "SigninMessengerwindow";
            SignInMessengerWindow.Dock = DockStyle.Fill;
            SignInMessengerWindow.Show();
            this.Controls.Add(SignInMessengerWindow);
        }

        private void SignInwindow1_showRegisterWindow(object sender, EventArgs e)
        {
            this.Controls["signInWindow1"].Hide();
            CreateNewAccount createnewAccount1 = new CreateNewAccount();
            createnewAccount1.Name = "createNewAccount1";
            createnewAccount1.Dock = DockStyle.Fill;
            createnewAccount1.showSignUpWindow += CreatenewAccount1_showSignUpWindow;
            createnewAccount1.ShowingEmailVerificationWindow += CreatenewAccount1_ShowingEmailVerificationWindow;
            this.Controls.Add(createnewAccount1);

        }

        private void CreatenewAccount1_ShowingEmailVerificationWindow(object sender, EventArgs e)
        {

            
            foreach(var allControls in Controls.OfType<Control>())
            {
                allControls.Visible = false;
            }
            

            // showing email Verify
            EmailVerfication EmailVerification = new EmailVerfication();
            EmailVerification.Name = "EmailVerify!";
            EmailVerification.Dock = DockStyle.Fill;
            EmailVerification.Visible = true;
            EmailVerification.HideEveryControl += EmailVerification_HideEveryControl;
            this.Controls.Add(EmailVerification);
        }

        private void EmailVerification_HideEveryControl(object sender, EventArgs e)
        {
            


            Thread.Sleep(1000);


            foreach (var allControls in this.Controls.OfType<Control>())
            {
                allControls.Hide();
            }

            // ShowMessengerWindow

            SelectProfilePic selectprofilePic1 = new SelectProfilePic();
            selectprofilePic1.Name = "selectProfilePic1";
            selectprofilePic1.Dock = DockStyle.Fill;
            selectprofilePic1.ShowMainMessengerWindow += SelectprofilePic1_ShowMainMessengerWindow;

            this.Controls.Add(selectprofilePic1);
            selectprofilePic1.Visible = true;



         

        }

        private void SelectprofilePic1_ShowMainMessengerWindow(object sender, EventArgs e)
        {
            // To hide every component
            HideEveryComponent();

         

            MessengerWindow messengerWindow1 = new MessengerWindow();
            messengerWindow1.Name = "messengerWindow1";
            messengerWindow1.Dock = DockStyle.Fill;
            this.Controls.Add(messengerWindow1);


            messengerWindow1.Show();

        }

        private void CreatenewAccount1_showSignUpWindow(object sender, EventArgs e)
        {
            this.Controls["createNewAccount1"].Hide();
            this.Controls["signInWindow1"].Visible = true;
        }

        public void offlineUser(int id)
        {
            db db1 = new db();
            var q = db1.users.Where((i) => i.id == id);
            if (q.Count() == 1)
            {
                User newUser = new User();
                newUser = q.Single();

                newUser.isOnline = false;

                db1.SaveChanges();
                Properties.Settings.Default.isOnline = false;
                Properties.Settings.Default.Save();
            }
        }

        public static bool fromClosing = true;

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
          try
            {
                if (fromClosing == true)
                {
                    db db1 = new db();

                    string userName = Properties.Settings.Default.UserName;
                    int id = (from i in db1.users where i.UserName == userName select i.id).Single();



                    if (MessageBox.Show("Do you want to close messengerX v.1.0.0", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        //to make the user become offline in user!
                        offlineUser(id);

                    }
                }
            }
            catch
            {
                // Do nothing
            }

            
        }
    }
}

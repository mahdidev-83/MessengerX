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
    public partial class CreateNewAccount : UserControl
    {
        public CreateNewAccount()
        {
            InitializeComponent();
            materialTextBox1.ForeColor = Color.FromArgb(204, 204, 204);
            MaterialTextBox a1 = new MaterialTextBox();
        }

        private void CreateNewAccount_Load(object sender, EventArgs e)
        {
            foreach(var Labels in Controls.OfType<Label>())
            {
                Labels.ForeColor = Color.FromArgb(204, 204, 204);
            }

            
           
        }

        private void CreateNewAccount_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null; // to unfocus the controls
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach(var Alltexts in panel1.Controls.OfType<MaterialTextBox>())
            {
                Alltexts.Clear();
            }
        }

        public event EventHandler showSignUpWindow;
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showSignUpWindow?.Invoke(this, EventArgs.Empty);
        }

        db db1 = new db();

        public bool Exist(User User)
        {
            db db_Exist = new db();
            return db_Exist.users.Any((i) => User.UserName == i.UserName || User.Email == i.Email);
        }

        public void addNewUser(User user)
        {
            
            if (Exist(user) != true) // it means if the user is not exising already!
            {
                try
                {
                    db1.users.Add(user);
                    db1.SaveChanges();

                    MessageBox.Show("Registered successfully!", "Sign up...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // prevent to 

                    UserName = materialTextBox1.Text;
                    Email = materialTextBox2.Text;
                    Password = materialTextBox3.Text;

                    this.Hide();

                    ShowingEmailVerificationWindow?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // the user is existing
            {
                MessageBox.Show("Registration Failed: The chosen credentials are already in use.\nPlease choose different credentials.", "error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public static string UserName;
        public static string Email;
        public static string Password;

        public event EventHandler ShowingEmailVerificationWindow;

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
             
            int d1 = random.Next(1, 9);
            int d2 = random.Next(1, 9);
            int d3 = random.Next(1, 9);
            int d4 = random.Next(1, 9);
            int d5 = random.Next(1, 9);
            int d6 = random.Next(1, 9);

            List<string> UserCodeDigits = new List<string>() { d1.ToString(),d2.ToString(),d3.ToString(),d4.ToString(),d5.ToString(),d6.ToString()};

            int result = int.Parse(string.Join(null, UserCodeDigits));
            

            bool allUserCode = db1.users.Any((i) => i.USERCODE == result);

            if (materialTextBox1.Text != string.Empty && materialTextBox2.Text != string.Empty && materialTextBox3.Text != string.Empty)
            {

               
                    if (!(materialTextBox1.Text.Length >= 6 && materialTextBox1.Text.Length <= 10))
                    {
                        MessageBox.Show("user name must be between 6 and 10 characters!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (materialTextBox2.Text.Contains("@gmail.com") || materialTextBox2.Text.Contains("@yahoo.com"))
                    {
                        // Do nothing
                    }
                    else
                    {
                        MessageBox.Show("Please correct the format of your email!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                if (allUserCode != true)
                {

                    // Register a new account/User
                    addNewUser(new User
                    {
                        UserName = materialTextBox1.Text,
                        Email = materialTextBox2.Text,
                        Password = hashPassword.getHashPassword(materialTextBox3.Text),
                        RegisterTime = DateTime.Now.ToString(),
                        USERCODE = result,
                        UserIdentity = $"{materialTextBox1.Text}{result}",
                        isBlocked = false

                    }
                    );

                    Properties.Settings.Default.UserName = materialTextBox1.Text;
                    Properties.Settings.Default.Email = materialTextBox2.Text;
                    Properties.Settings.Default.Password = materialTextBox3.Text;
                    Properties.Settings.Default.UserIdentity = $"{materialTextBox1.Text}{result}";
                    Properties.Settings.Default.NeedToregister = true; // this line have to change to true
                    Properties.Settings.Default.registerTime = DateTime.Now.ToString();
                    Properties.Settings.Default.isOnline = true;

                    Properties.Settings.Default.Save(); // to save all the Changes 







                    // Showing the email verification window









                }

            }
            else
            {
                MessageBox.Show("Please fill all of the entries with correct format of information!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            





        }
    }
}

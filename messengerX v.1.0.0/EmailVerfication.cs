using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace messengerX_v._1._0._0
{
    public partial class EmailVerfication : UserControl
    {
        public EmailVerfication()
        {
            InitializeComponent();

           
        }



        int result;

        public void sendEmailInfo()
        {
            string UserName = CreateNewAccount.UserName;
            string Email = CreateNewAccount.Email;
            string password = CreateNewAccount.Password;




            string message = $@"just now a 4 digit verification code 
just sent to {Email},Please enter the code 
to verify your email and submit your account!";




            label1.Text = $"Dear {UserName} Please verify your email account!";

            label2.Text = message;


            // Sending Email Code to User Email's

            SmtpClient smtpclient1 = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Credentials = new NetworkCredential("mahdidev83@gmail.com", "ghbk lbdv sxrw fnrj")

            };

            Random random1 = new Random();

            int d1 = random1.Next(1, 9);
            int d2 = random1.Next(1, 9);
            int d3 = random1.Next(1, 9);
            int d4 = random1.Next(1, 9);

            List<string> VerifyList = new List<string>();

            VerifyList.Add(d1.ToString());
            VerifyList.Add(d2.ToString());
            VerifyList.Add(d3.ToString());
            VerifyList.Add(d4.ToString());

            result = int.Parse(string.Join(null, VerifyList));


            string Message = $@"Hello {UserName}!
we are welcoming you to the Heaven Peace (2018-2024) messengerX.
To use messengerX you have to verify Your Email and Submit your account!

the verification Code : {result}";




            smtpclient1.Send("mahdidev83@gmail.com", Email, "messengerX verfication", Message);
        }
        private void EmailVerfication_Load(object sender, EventArgs e)
        {


            sendEmailInfo();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Focus();
        }

        public event EventHandler HideEveryControl;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            List<string> MainNumberList = new List<string>();

            MainNumberList.Add(textBox1.Text);
            MainNumberList.Add(textBox2.Text);
            MainNumberList.Add(textBox3.Text);
            MainNumberList.Add(textBox4.Text);

            int ListResult = int.Parse(string.Join(null, MainNumberList));

            if(ListResult != result)
            {


              
                label3.Visible = true;
                MessageBox.Show("the entered code isn't correct!\nPlease try again!", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Show the messenger Message and sending message Section Window
                this.Hide();
                HideEveryControl?.Invoke(this, EventArgs.Empty);
              
            



            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

       
        private void label3_Click(object sender, EventArgs e)
        {

            sendEmailInfo();
            MessageBox.Show("The code has been sent to your email!", "Verification code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace messengerX_v._1._0._0
{
    public partial class SelectProfilePic : UserControl
    {
        public SelectProfilePic()
        {
            InitializeComponent();
        }
        public event EventHandler ShowMainMessengerWindow;
        public void setProfilePicture(int id)
        {
            try
            {
                db db_Update = new db();

                var q = db_Update.users.Where((i) => i.id == id);
                if (q.Count() == 1)
                {
                    User oldUser = new User();
                    oldUser = q.Single();
                    // set the profile picture
                    oldUser.ProfilePicture = readImage(rjCircularPictureBox1.ImageLocation);
                    db_Update.SaveChanges();

                  

                    // to invoke the showing main messenger window event
                 

                    MessageBox.Show("the Profile Picture changed successfully!", "change picture", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Properties.Settings.Default.NeedToregister = true;
                    Properties.Settings.Default.Save();

                    ShowMainMessengerWindow?.Invoke(this, EventArgs.Empty);

                    

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        byte [] readImage(string filename)
        {
            return File.ReadAllBytes(filename);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(rjCircularPictureBox1.ImageLocation == string.Empty)
            {
                MessageBox.Show("Please select an picture for your profile!", "select image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                try
                {
                    string Username = Properties.Settings.Default.UserName;
                    db db_search = new db();
                    int id = (from i in db_search.users where i.UserName == Username select i.id).Single();

                    setProfilePicture(id);

                    Properties.Settings.Default.needSelectPic = false;
                    Properties.Settings.Default.Save();

                    ShowMainMessengerWindow?.Invoke(this, EventArgs.Empty);
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void SelectProfilePic_Load(object sender, EventArgs e)
        {
            rjCircularPictureBox1.Image = Image.FromFile("defaultImage.png");


            materialTextBox1.Text = Properties.Settings.Default.UserName;
            materialTextBox2.Text = Properties.Settings.Default.Email;
            materialTextBox3.Text = Properties.Settings.Default.Password;

            Properties.Settings.Default.needSelectPic = true;
            

            Properties.Settings.Default.Save();


            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PictureSelect.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg, *.jpeg)|*.jpg;*.jpeg";
            PictureSelect.ShowDialog();

            rjCircularPictureBox1.ImageLocation = PictureSelect.FileName;


        }

         

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
       
        }
    }
}

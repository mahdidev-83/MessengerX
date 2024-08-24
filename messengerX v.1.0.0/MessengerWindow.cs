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
using CustomControls.CircularPicturebox;
using Tulpep.NotificationWindow;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity;
using System.Threading;
using messengerX_v._1._0._0.Migrations;
using System.Media;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Runtime.Remoting.Messaging;
using Windows.ApplicationModel.Activation;


namespace messengerX_v._1._0._0
{
    public enum option
    {
        Username,
        Email,
        registerTime,
        UserID,
        isOnline,
        ProfilePicture
    }

   

    public partial class MessengerWindow : UserControl
    {
        List<Button> buttons = new List<Button>();
        public MessengerWindow()
        {
            InitializeComponent();
            foreach(var AllUserProfiles in panel1.Controls.OfType<RJCircularPictureBox>())
            {
                AllUserProfiles.MouseEnter += AllUserProfiles_MouseEnter;
            }

            // to gather all the buttons for change the WAV sound file
            foreach(var AllSoundButtons in materialCard1.Controls.OfType<Button>())
            {
               if(AllSoundButtons.GetType() == typeof(Button) && (string)AllSoundButtons.Tag == "soundtag")
                {
                    AllSoundButtons.Click += AllSoundButtons_Click;
                    buttons.Add(AllSoundButtons);
                }
            }
            // Find the other Type of blazor
        }

        public void ChangeTheSound(string sound)
        {
            Properties.Settings.Default.soundName = sound;
            Properties.Settings.Default.Save();
        }

        private async void AllSoundButtons_Click(object sender, EventArgs e)
        {
            //if(Properties.Settings.Default.mustPlay == false)
            //{

            //    materialSwitch1.Text = isChecked();
            //    changeMustplay();

            //    foreach(var allbuttons in buttons)
            //    {
            //        allbuttons.Enabled = true;
            //    }
            //}
            // To change the sound file
            
            Button btn = (Button)sender;
            if(btn != null)
            {
                // Change the sound
                ChangeTheSound($"{btn.Text.ToLower()}.wav");
                await UserMessenger.PlayingSound($"{btn.Text}.wav");
            }
        }

        db db1 = new db();

        private void AllUserProfiles_MouseEnter(object sender, EventArgs e)
        {
           RJCircularPictureBox ProfilePicture = (RJCircularPictureBox)sender;
           foreach(var AllUserProfiles in panel1.Controls.OfType<RJCircularPictureBox>())
            {
                if(AllUserProfiles is RJCircularPictureBox && (string)AllUserProfiles.Tag == "User")
                {
                    toolTipProfile.SetToolTip(AllUserProfiles, AllUserProfiles.Name);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = Properties.Settings.Default.UserName;
            string Email = Properties.Settings.Default.Email;
            string password = Properties.Settings.Default.Password;
            bool needtoRegister = Properties.Settings.Default.NeedToregister;
            bool needToselectPic = Properties.Settings.Default.needSelectPic;

            MessageBox.Show(Username);
            MessageBox.Show(Email);
            MessageBox.Show(password);
            MessageBox.Show(needtoRegister.ToString());
            MessageBox.Show(needToselectPic.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserName = string.Empty;
            Properties.Settings.Default.Email = string.Empty;
            Properties.Settings.Default.Password = string.Empty;
            Properties.Settings.Default.needSelectPic = false;
            Properties.Settings.Default.NeedToregister = false;

            Properties.Settings.Default.Save();

            MessageBox.Show("All Data Cleared!");
        }

        bool openUserInfo;


        public void onlineUser(int id)
        {
            db db1 = new db();
            var q = db1.users.Where((i) => i.id == id);
            if (q.Count() == 1)
            {
                User newUser = new User();
                newUser = q.Single();

                newUser.isOnline = true;

                db1.SaveChanges();
                Properties.Settings.Default.isOnline = true;
                Properties.Settings.Default.Save();
            }
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

        public object getInformation(int inputID, option option)
        {
            db dbSearch = new db();

            string Username = dbSearch.users.Where((i) => i.id == inputID).Select((i) => i.UserName).Single();
            string Email = dbSearch.users.Where((i) => i.id == inputID).Select((i) => i.Email).Single();
            string registerTime = dbSearch.users.Where((i) => i.id == inputID).Select((i) => i.RegisterTime).Single();
            string UserID = dbSearch.users.Where((i) => i.id == inputID).Select((i) => i.UserIdentity).Single();
            bool isOnline = dbSearch.users.Where((i) => i.id == inputID).Select((i) => i.isOnline).Single();
            byte[] ProfilePicture = dbSearch.users.Where((i) => i.id == inputID).Select((i) => i.ProfilePicture).Single();

            MemoryStream ReadProfilePicture = new MemoryStream(ProfilePicture);
            Image ProfileImage = Image.FromStream(ReadProfilePicture);


            //MessageBox.Show(Username);
            //MessageBox.Show(Email);
            //MessageBox.Show(registerTime);
            //MessageBox.Show(UserID);
            //MessageBox.Show(isOnline.ToString());


            if (option == option.Username)
            {
                return Username;
            }
            else if (option == option.Email)
            {
                return Email;
            }
            else if (option == option.registerTime)
            {
                return registerTime;
            }
            else if(option == option.UserID)
            {
                return UserID;
            }
            else if(option == option.isOnline)
            {
                return isOnline;
            }
            else if(option == option.ProfilePicture)
            {
                return ProfileImage;
            }
            else
            {
                return null; // Do nothing and just break the loop!
            }







        }


        public ColorBorder setColor(int inputID)
        {
            db dbSearch = new db();

            string Username = dbSearch.users.Where((i) => i.id == inputID).Select((i) => i.UserName).Single();
            string Email = dbSearch.users.Where((i) => i.id == inputID).Select((i) => i.Email).Single();
            string registerTime = dbSearch.users.Where((i) => i.id == inputID).Select((i) => i.RegisterTime).Single();
            string UserID = dbSearch.users.Where((i) => i.id == inputID).Select((i) => i.UserIdentity).Single();
            bool isOnline = dbSearch.users.Where((i) => i.id == inputID).Select((i) => i.isOnline).Single();
            byte[] ProfilePicture = dbSearch.users.Where((i) => i.id == inputID).Select((i) => i.ProfilePicture).Single();

            MemoryStream ReadProfilePicture = new MemoryStream(ProfilePicture);
            Image ProfileImage = Image.FromStream(ReadProfilePicture);

            ColorBorder onlineBorderColor = new ColorBorder()
            {
                BorderColor1 = Color.FromArgb(179, 254, 254), //Color.FromArgb(72, 244, 246),
                BorderColor2 = Color.Green
            };

            ColorBorder offlineBorderColor = new ColorBorder()
            {
                BorderColor1 = Color.FromArgb(37, 37, 38),
                BorderColor2 = Color.FromArgb(37, 37, 38)
            };


            switch (isOnline)
            {
                case true:
                    return onlineBorderColor;
                case false:
                    return offlineBorderColor;
                default:
                    return null;

            }
          
           
           
        }
        public string getButtonSoundText()
        {
            bool playingSound = Properties.Settings.Default.mustPlay;
            if(playingSound == true)
            {
                return "Enabled";
            }
            return "Disabled";
        }

        // To show the contacts that we add in the database
        public  void showContacts()
        {
            db dbcontact = new db();

            int id = (from i in dbcontact.users where i.UserName == Properties.Settings.Default.UserName select i.id).Single();
            var AllContacts = dbcontact.relations.Where((i) => i.MainUserID == id);

            List<int> IDs = new List<int>();

            foreach(var item in AllContacts)
            {
                //MessageBox.Show(item.requestedUserID.ToString(),"moosh");
                IDs.Add(item.requestedUserID);
            }

            int top = 80;
            Color BorderColor = Color.FromArgb(37, 37, 38);
            foreach(var item in IDs)
            {
                RJCircularPictureBox UserProfile = new RJCircularPictureBox();
                UserProfile.Name = (string)getInformation(item, option.Username);
                UserProfile.Size = new Size(61, 61);
                UserProfile.Image = (Image)getInformation(item, option.ProfilePicture);
                UserProfile.Tag = "User";
                UserProfile.Top = top;
                UserProfile.BorderSize = 2;
                UserProfile.Location = new Point(4, 130 + top);
                UserProfile.Cursor = Cursors.Hand;
                UserProfile.Click += UserProfile_Click;
                UserProfile.BorderColor = setColor(item).BorderColor1;
                UserProfile.BorderColor2 = setColor(item).BorderColor2;
                
                UserProfile.Visible = true;

                panel1.Controls.Add(UserProfile);

                


                top += 67;

                //MessageBox.Show(item.ToString());
                //MessageBox.Show(((rjCircularPictureBox2.Location.Y) - (rjCircularPictureBox1.Location.Y)).ToString(), "rj2 Y - rj1 Y");
                //MessageBox.Show(((label1.Location.Y) - (rjCircularPictureBox2.Location.Y)).ToString(),"lbl1 y - rj y");
                //MessageBox.Show(label1.Location.Y.ToString(),"lbl1 y");
                //MessageBox.Show(rjCircularPictureBox1.Location.X.ToString(),"rj X");
                //MessageBox.Show(rjCircularPictureBox1.Location.Y.ToString(),"rj Y");






            }

          

        }


        public static string UserName;
        public static string UserID;
        public static bool isOnline;
        public static  Image ProfilePicture;

        

        private void UserProfile_Click(object sender, EventArgs e)
        {
            foreach(Control allItem in Controls)
            {
                if(allItem.GetType() ==  typeof(UserMessenger))
                {
                    Controls.Remove(allItem);
                }
            }




            db db1 = new db();
            RJCircularPictureBox UserProfile = (RJCircularPictureBox)sender;
            if (UserProfile != null)
            {
                UserName = UserProfile.Name;
            }
            UserID = db1.users.Where((i) => i.UserName == UserProfile.Name).Select((i) => i.UserIdentity).Single();
            isOnline = db1.users.Where((i) => i.UserName == UserProfile.Name).Select((i) => i.isOnline).Single();
            byte [] ReadProfilePicture = db1.users.Where((i) => i.UserName == UserProfile.Name).Select((i) => i.ProfilePicture).Single();
            MemoryStream MemoryStream1 = new MemoryStream(ReadProfilePicture);

            Image ProfileImage = Image.FromStream(MemoryStream1);

            ProfilePicture = ProfileImage;


            // set the values of the static variables

            materialCard1.Hide();
            PanelMsg.Hide();

            if(PanelMsg.Visible == true)
            {
                PanelMsg.Visible = false;
            }
            

        

            // Profile User Click Section:
            #region userMessenger
            UserMessenger usermessenger1 = new UserMessenger();
            usermessenger1.Name = "userMessenger1";
            usermessenger1.Dock = DockStyle.Right;
            usermessenger1.BringToFront();
            usermessenger1.eventShowContacts += Usermessenger1_showContacts;
            usermessenger1.Visible = true;
            this.Controls.Add(usermessenger1);







            //Controls["usermessenger1"].Show();

            #endregion


            //string lblName1 = (from i in this.Controls.OfType<Label>() where i.Text.Contains("someone") select i.Name).Single();


            //MessageBox.Show(lblName1);

            label2.SendToBack();
          



        }

        private void Usermessenger1_showContacts(object sender, EventArgs e)
        {
            //MessageBox.Show("please restart your application in order to synch your data!", "synch data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            foreach(var allUsers in panel1.Controls.OfType<RJCircularPictureBox>())
            {
                if(allUsers is RJCircularPictureBox && (string)allUsers.Tag == "User")
                {
                    allUsers.Hide(); // to hide every user control
                }
            }

            foreach(var everyUsermessenger in this.Controls.OfType<UserMessenger>())
            {
                everyUsermessenger.Hide(); 
            }

            showContacts();
        }

        public int? FrontUserMaxMessageID;

       
       
        private async void MessengerWindow_Load(object sender, EventArgs e)
        {
            db db1 = new db();


            string userName = Properties.Settings.Default.UserName;

            int id = (from i in db1.users where i.UserName == userName select i.id).Single();

            Boolean isBanned = db1.users.Where((i) => i.id == id).Select((i) => i.isBlocked).Single();

            // 
            if (isBanned)
            {
                foreach(var ALLCONTROLS in Controls.OfType<Control>())
                {
                    ALLCONTROLS.SendToBack();

                }
                panel1.Hide();
                BannedWindow bannedWindow = new BannedWindow();
                bannedWindow.Name = "bannedWindow1";
                bannedWindow.Dock = DockStyle.Fill;
                this.Controls.Add(bannedWindow);
                bannedWindow.BringToFront();

                bannedWindow.Show();
                

            }
            else
            {
                #region showingThecomponent
                materialCard1.AutoScroll = true;
                materialCard1.AutoScrollMargin = new Size(0, +10);
                //Properties.Settings.Default.UserName = string.Empty;
                //Properties.Settings.Default.Email = string.Empty;
                //Properties.Settings.Default.Password = string.Empty;
                //Properties.Settings.Default.needSelectPic = false;
                //Properties.Settings.Default.NeedToregister = false;

                //Properties.Settings.Default.Save();

                //MessageBox.Show("All Data Cleared!");





                var blockedUserIds = db1.blockedUser
        .Where(u => u.MainUserID == id)
        .Select(u => u.relatedID)
        .ToList(); // Eagerly load related IDs

                var blockedUsers = db1.users
                    .Where(u => blockedUserIds.Contains(u.id))
                    .Select(u => new { Username = u.UserName })
                    .ToList(); // Eagerly load usernames

                datagridBlockedUsers.DataSource = null;
                datagridBlockedUsers.DataSource = blockedUsers;




                if (Properties.Settings.Default.mustPlay == true)
                {

                    materialSwitch1.Text = isChecked();


                    foreach (var allbuttons in buttons)
                    {
                        allbuttons.Enabled = true;
                    }
                }
                else if (Properties.Settings.Default.mustPlay == false)
                {

                    materialSwitch1.Text = isChecked();


                    foreach (var allbuttons in buttons)
                    {
                        allbuttons.Enabled = false;
                    }
                }


                PanelMsg.Visible = false;
                PanelMsg.ShowcontactsEvent += FindUser1_ShowcontactsEvent;


                string Username = Properties.Settings.Default.UserName;
                string Email = Properties.Settings.Default.Email;
                string password = Properties.Settings.Default.Password;
                bool needtoRegister = Properties.Settings.Default.NeedToregister;
                bool needToselectPic = Properties.Settings.Default.needSelectPic;
                string RegisterTime = Properties.Settings.Default.registerTime;
                bool isOnline = Properties.Settings.Default.isOnline;
                string UserID = Properties.Settings.Default.UserIdentity;



                bool AppearOffline = Properties.Settings.Default.AppearOffline;







                if (AppearOffline == false) // it means the appear offline is not activated / 
                {
                    onlineUser(id);
                    materialComboBox1.SelectedItem = "Default";
                }
                else
                {
                    offlineUser(id);
                    materialComboBox1.SelectedItem = "Appear Offline";
                }





                openUserInfo = false;

                materialCard1.Hide();



                Properties.Settings.Default.NeedToregister = true;
                Properties.Settings.Default.Save();










                //to show the Profile of the user
                db dbSearch = new db();
                byte[] ProfilePicture = (from i in dbSearch.users where i.UserName == Properties.Settings.Default.UserName select i.ProfilePicture).Single();

                MemoryStream memoryStream1 = new MemoryStream(ProfilePicture); // we put the Profile Picture in the memoryStream

                Image UserProfilePicture = Image.FromStream(memoryStream1);

                rjCircularPictureBox1.Image = UserProfilePicture;
                //rjCircularPictureBox5.Image = UserProfilePicture;

                // Usercard inforamtion









                lblUsername.Text = $"User name : {Username}";
                lblEmail.Text = $"Signed in Email : {Email}";
                lblRegTime.Text = $"register Time : {RegisterTime}";
                lblId.Text = $"UserID : {UserID}";
                lblisOnline.Text = $"isOnline : {isOnline}";

                rjCircularPictureBox3.Image = UserProfilePicture;


                // To show in the AppearOffline combobox to when the value is true show in the combobox AppearOffline but when the value is false show Default value in the combobox






                string labelName = (from i in Controls.OfType<Label>() where i.Text.Contains("someone") select i.Name).Single();

                //MessageBox.Show(labelName);

                label1.SendToBack();

                // 
                int myId = await Task.Run(() => db1.users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single());
                try
                {
                    FrontUserMaxMessageID = db1.messages.Where((i) => i.toU == myId && i.id == db1.messages.Max((j) => j.id)).Select((i) => i.id).Single();

                }

                catch
                {
                    // Do nothing!
                }



                // 

                //buttonPlaySound.Text = getButtonSoundText();





                showContacts();
                bool mustplay = Properties.Settings.Default.mustPlay;
                materialSwitch1.Checked = mustplay;
                materialSwitch1.Text = isChecked();
                #endregion
            }

            // the main verse

















        }

        private void FindUser1_ShowcontactsEvent(object sender, EventArgs e)
        {
            showContacts();
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {
            foreach(var allUserProfile in panel1.Controls.OfType<UserMessenger>())
            {
                
                    if(allUserProfile.Visible == true)
                    {
                        materialCard1.Hide();
                        break;

                    }
                    else
                    {
                        materialCard1.Show();
                        break;
                    
                }
            }

           




            if (!openUserInfo)
            {

                openUserInfo = true;
                materialCard1.Visible = true;
            }
            else //if(openUserInfo)
            {
                openUserInfo = false;
                materialCard1.Visible = false;
            }


            if (PanelMsg.Visible == true)
            {
                PanelMsg.Hide();
                label2.Show();
            }

            // the whole stroy:




           
            try
            {
                var usermessengerInControl = Controls["userMessenger1"];
                if (usermessengerInControl != null &&usermessengerInControl.Visible)
                {
                    Controls["userMessenger1"].Hide();
                }
            }
            catch
            {
                // Do nothing
                
            }

         
            foreach (var UserProfile in Controls.OfType<UserMessenger>())
            {
                UserProfile.Hide();
            }

            PanelMsg.Hide();

            string userName = Properties.Settings.Default.UserName;

            int id = (from i in db1.users where i.UserName == userName select i.id).Single();

            var blockedUserIds = db1.blockedUser
    .Where(u => u.MainUserID == id)
    .Select(u => u.relatedID)
    .ToList(); // Eagerly load related IDs

            var blockedUsers = db1.users
                .Where(u => blockedUserIds.Contains(u.id))
                .Select(u => new { Username = u.UserName })
                .ToList(); // Eagerly load usernames

            datagridBlockedUsers.DataSource = null;
            datagridBlockedUsers.DataSource = blockedUsers;








        }

        private void lblUserId_Click(object sender, EventArgs e)
        {
            materialCard1.Hide();
        }


        bool showFindUser = false;

        private void rjCircularPictureBox2_Click(object sender, EventArgs e)
        {
            label2.SendToBack();
            if (!showFindUser)
            {
                if (materialCard1.Visible == true)
                {
                    materialCard1.Hide();
                }

                showFindUser = true;
                // show find user
                PanelMsg.Visible = true;


            }
            else
            {
                showFindUser = false;
                //hide find user
                PanelMsg.Visible = false;
            }
            foreach (var UserProfile in Controls.OfType<UserMessenger>())
            {
                UserProfile.Hide();
            }
            materialCard1.Hide();
            



        }

        private void lblId_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Properties.Settings.Default.UserIdentity);
            MessageBox.Show("Copied to clipboard!", "User Identity", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      

        private void rjCircularPictureBox3_Click(object sender, EventArgs e)
        {
            //To show the Dialog and change the profile Picture
            ChangeProfilePicture.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg, *.jpeg)|*.jpg;*.jpeg";
            if (ChangeProfilePicture.ShowDialog() == DialogResult.OK)
            {
                db db1 = new db();
                int id = (from i in db1.users where i.UserName == Properties.Settings.Default.UserName select i.id).Single();
                changeProfilePicture(id);

                db dbSearch = new db();
                byte[] ProfilePicture = (from i in dbSearch.users where i.UserName == Properties.Settings.Default.UserName select i.ProfilePicture).Single();

                MemoryStream memoryStream1 = new MemoryStream(ProfilePicture); // we put the Profile Picture in the memoryStream

                Image UserProfilePicture = Image.FromStream(memoryStream1);

                rjCircularPictureBox1.Image = UserProfilePicture;
                rjCircularPictureBox3.Image = UserProfilePicture;
            }
            else
            {
                db dbSearch = new db();
                byte[] ProfilePicture = (from i in dbSearch.users where i.UserName == Properties.Settings.Default.UserName select i.ProfilePicture).Single();

                MemoryStream memoryStream1 = new MemoryStream(ProfilePicture); // we put the Profile Picture in the memoryStream

                Image UserProfilePicture = Image.FromStream(memoryStream1);

                rjCircularPictureBox1.Image = UserProfilePicture;
            }


        }


        public void changeProfilePicture(int id)
        {
            try
            {
                db dbSearch = new db();
                var q = dbSearch.users.Where((i) => i.id == id);
                if (q.Count() == 1)
                {
                    User newUser = new User();
                    newUser = q.Single();


                    newUser.ProfilePicture = ReadImages(ChangeProfilePicture.FileName);
                    dbSearch.SaveChanges();

                    //MessageBox.Show("the Profile Picture changed!", "changing profile picture", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public byte [] ReadImages(string inputPath)
        {
            return File.ReadAllBytes(inputPath);
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool Isonline = Properties.Settings.Default.isOnline;
            db db1 = new db();

            string userName = Properties.Settings.Default.UserName;
            int id = (from i in db1.users where i.UserName == userName select i.id).Single();

            if ((string)materialComboBox1.SelectedItem == "Default")
            {
                onlineUser(id);
                Properties.Settings.Default.AppearOffline = false;
                Properties.Settings.Default.Save();
                Isonline = true;
                
                lblisOnline.Text = $"isOnline : {Isonline}";

              

            }
           else if((string)materialComboBox1.SelectedItem == "Appear Offline")
            {
                offlineUser(id);
                Properties.Settings.Default.AppearOffline = true;
                Properties.Settings.Default.Save();
                Isonline = false; // it means the user has to be shown offline
               
                lblisOnline.Text = $"isOnline : {Isonline}";

               

            }
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            if(panel1.Visible == true)
            {
                showContacts();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
          
            
        }

        private void TimerShowContact_Tick(object sender, EventArgs e)
        {
            showContacts();
            
        }

        public Message getLatestMessage()
        {
            try 
            {
                int myID = db1.users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single();
                return db1.messages.Where((i) => i.toU == myID).ToList().OrderByDescending((i) => i.id).First();
            }
            catch { return null; } 
        }

        

        public void showcontent(string username, string content, Image ProfilePicture)
        {
            //#region showComponent
            //in_notif.Show();
            //lbluser.Visible = true;
            //lblContent.Visible = true;
            //lblUsername.Visible = true;
            //#endregion

            lbluser.Text = username;
            lblContent.Text = content;
            RjProfilePicture.Image = ProfilePicture;
        }


        public Image getProfileImage(int lastmessageid)
        {
            string Owner = db1.messages.Where((i) => i.id == lastmessageid).Select((i)=>i.Owner).Single();
            byte[] ProfilePictureBinary = db1.users.Where((i) => i.UserName == Owner).Select((i) => i.ProfilePicture).Single();

            MemoryStream ProfilePictureStream = new MemoryStream(ProfilePictureBinary);

            Image ProfilePictureimage = Image.FromStream(ProfilePictureStream);

            return ProfilePictureimage;
            
        }

        public async Task PlayingSound(string sound)
        {
            SoundPlayer soundplayer = new SoundPlayer(sound);
            await Task.Run(() => soundplayer.PlaySync());
            return;


        }


        public string defineMessageText(string input)
        {
           if(input.Length >= 20)
                return "(New Unread Message!)";
            return input;
        }


        public async Task checkNewMessage()
        {
            try
            {

                string inUsername = UserMessenger.inUsername;

                int meID = db1.users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single();
                var getlatestmessage = getLatestMessage();
                if (getlatestmessage != null && getlatestmessage.toU == meID)
                {
                    if (getlatestmessage != null && getlatestmessage.id == FrontUserMaxMessageID) // after the debug mode in the last section
                    {
                        // Do nothing

                        //lbluser.Text = null;


                        await Task.Run(() => Task.Delay(2000));


                        in_notif.Hide();
                        lblContent.Text = string.Empty;
                        RjProfilePicture.Image = null;
                        lbluser.Text = string.Empty;

                    }
                    else
                    {
                        try
                        {
                            string getlbluser = string.Empty;

                            // Check if the current username matches the username in the latest message
                            var getLatestMessages = getLatestMessage();
                            if (getlatestmessage != null && getLatestMessages.Owner == inUsername)
                            {
                                // Hide the notification if the message is from the current conversation partner
                                in_notif.Hide();
                            }
                            else
                            {
                                // Update notification content with the latest message details
                                RjProfilePicture.Image = getProfileImage(getLatestMessage().id);
                                lbluser.Text = getLatestMessage().Owner;
                                lblContent.Text = defineMessageText(getLatestMessage().text);
                                in_notif.BringToFront();
                                in_notif.Show();
                                this.FrontUserMaxMessageID = getLatestMessage().id;

                                getlbluser = lbluser.Text; // Update getlbluser after displaying notification
                                in_notif.BringToFront();

                                var usermessengerControl = this.Controls["userMessenger1"];
                                if (Properties.Settings.Default.mustPlay )//&& (usermessengerControl == null || usermessengerControl.Visible == false))
                                {
                                    // Play the sound regardless of usermessengerControl
                                    
                                    string defaultSound = Properties.Settings.Default.soundName;
                                    await PlayingSound(defaultSound);
                                }

                                // playing sound alongside the notification



                            }


                            //in_notif.Controls["lbluser"].Text = getLatestMessage().Owner;
                            //in_notif.Controls["lblContent"].Text = getLatestMessage().text;
                            //in_notif.Controls["RjProfilePicture"].BackgroundImage = ProfilePictureImage;
                            //MessageBox.Show("yes!");





                            //MessageBox.Show(inUsername,"user messenger in username");
                            //MessageBox.Show(getlbluser,"lbl user!");
















                        }
                        catch
                        {
                            return;
                        }


                    }
                }
            }
            catch
            {
                // Do nothing!
            }
        }

        private async void TimerReadData_Tick(object sender, EventArgs e)
        {
            await checkNewMessage();
        }

        private async  void button4_Click(object sender, EventArgs e)
        {
            Message message1 = new Message()
            {
                datetime = DateTime.Now,
                fromU = 2,
                toU = 1002,
                text = "sag!",
                Owner = "Jinuwoo"
            };

            db1.messages.Add(message1);
            await db1.SaveChangesAsync();
        }


       

       

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void in_notif_VisibleChanged(object sender, EventArgs e)
        {
         
        }

        private  void button3_Click(object sender, EventArgs e)
        {
            //if (panel1.Visible)
            //{
            //    panel1.Hide();
            //    if (this.Controls.ContainsKey("userMessenger1"))
            //    {
            //        if (Controls["userMessenger1"].Visible)
            //            Controls["userMessenger1"].Dock = DockStyle.Fill;
            //    }
            //}
            //else if (!panel1.Visible)
            //{
            //    panel1.Show();
            //    if(Controls["userMessenger1"].Visible || !Controls["userMessenger1"].Visible)
            //        Controls["userMessenger1"].Dock = DockStyle.Right;
            //}
            // Main operation:
           

        }

        private void rjCircularPictureBox5_Click(object sender, EventArgs e) // Copied!
        {
            foreach (var allUserProfile in panel1.Controls.OfType<UserMessenger>())
            {

                if (allUserProfile.Visible == true)
                {
                    materialCard1.Hide();
                    break;

                }
                else
                {
                    materialCard1.Show();
                    break;

                }
            }





            if (!openUserInfo)
            {

                openUserInfo = true;
                materialCard1.Visible = true;
            }
            else //if(openUserInfo)
            {
                openUserInfo = false;
                materialCard1.Visible = false;
            }


            if (PanelMsg.Visible == true)
            {
                PanelMsg.Hide();
                label2.Show();
            }

            // the whole stroy:





            try
            {
                var usermessengerInControl = Controls["userMessenger1"];
                if (usermessengerInControl != null && usermessengerInControl.Visible)
                {
                    Controls["userMessenger1"].Hide();
                }
            }
            catch
            {
                // Do nothing

            }


            foreach (var UserProfile in Controls.OfType<UserMessenger>())
            {
                UserProfile.Hide();
            }

            PanelMsg.Hide();



        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(rjCircularPictureBox1.Size.ToString());
            MessageBox.Show(rjCircularPictureBox2.Size.ToString());



        }


        public string isChecked()
        {
            if (materialSwitch1.Checked)
                return "Enabled";
            return "Disabled";
        }

        public void changeMustplay()
        {
          

            if (Properties.Settings.Default.mustPlay == false)
            {
               
                Properties.Settings.Default.mustPlay = true;
                Properties.Settings.Default.Save();
            }
            else if(Properties.Settings.Default.mustPlay == true)
            {
              
                Properties.Settings.Default.mustPlay = false;
                Properties.Settings.Default.Save();
            }
                
        }
        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            // Declaration of the variables
            //bool MustPlay = Properties.Settings.Default.mustPlay;


            //materialSwitch1.Text = isChecked();
            //changeMustplay();

        }

        private void materialSwitch1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.mustPlay == true)
            {

                materialSwitch1.Text = isChecked();
                

                foreach (var allbuttons in buttons)
                {
                    allbuttons.Enabled = false;
                }
            }
            else if (Properties.Settings.Default.mustPlay == false)
            {

                materialSwitch1.Text = isChecked();
               

                foreach (var allbuttons in buttons)
                {
                    allbuttons.Enabled = true;
                }
            }


            bool MustPlay = Properties.Settings.Default.mustPlay;


            materialSwitch1.Text = isChecked();
            changeMustplay();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(Properties.Settings.Default.UserIdentity);
            MessageBox.Show("the user id copied to clipboard!", "user id", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public int getUserID(string username)
        {
            return db1.users.Where((i) => i.UserName == username).Select((i) => i.id).Single();
        }

        private void restorefromblockuser(int thisID,int frontuserID)
        {
            try
            {
                var q = db1.blockedUser.Where((i) => i.MainUserID == thisID && i.relatedID == frontuserID);

                if(q.Count() == 1)
                {
                    db1.blockedUser.Remove(q.Single());
                    db1.SaveChangesAsync();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private  void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string blockedUserName = (string)(datagridBlockedUsers.Rows[0].Cells[0].Value);
            int thisID = db1.users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single();
            int FrontUserID = db1.users.Where((i) => i.UserName == blockedUserName).Select((i) => i.id).Single();

            restorefromblockuser(thisID, FrontUserID);

            //datagridBlockedUsers.DataSource = null;


            string userName = Properties.Settings.Default.UserName;

            int id = (from i in new db().users where i.UserName == userName select i.id).Single();

            var blockedUserIds = new db().blockedUser
    .Where(u => u.MainUserID == id)
    .Select(u => u.relatedID)
    .ToList(); // Eagerly load related IDs

            var blockedUsers = new db().users
                .Where(u => blockedUserIds.Contains(u.id))
                .Select(u => new { Username = u.UserName })
                .ToList(); // Eagerly load usernames

            datagridBlockedUsers.DataSource = null;
            datagridBlockedUsers.DataSource = blockedUsers;



            datagridBlockedUsers.DataSource = blockedUsers;
            
            
        }
    }
}


#region Errors
/* tasks:
 * 1) fixing the hash passowrd in retrieving password               -----> fixed!
 * 2) fixing showcontacts                                           -----> fixed!
 * 3) fixing the blocked list users                                 -----> fixed!
 * 4) fixing the finding user Time                                  -----> fixed!
 * 5) fixing the unblocking list for the user                       
 * 6) fixing the profiler that make a lot of instance of it when i click the UserProfile icon -----> fixed!
 * 7) fixing the textbox issue (if needed) 
 * 
 */
#endregion
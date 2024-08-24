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
using CustomControls.CircularPicturebox;
using System.Data.Entity;
using Tulpep.NotificationWindow;
using System.Runtime.CompilerServices;
using System.Media;
using Windows.Media.Playback;







namespace messengerX_v._1._0._0
{
    public partial class UserMessenger : UserControl
    {

        db db1 = new db();

        Point MainLocation = new Point(3, 8);
        Font PrioFont = new Font("Roboto", 13f);
        int MainY = 45;//15;
        string mUsername = Properties.Settings.Default.UserName;

        int toUID; 
        int fromID;




        public UserMessenger()
        {
            InitializeComponent();

            // click on the materialcards and copy the text inside it
            
           
            

        }

        

        public int indicateUserName(string text)
        {

            int fromID = db1.users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single();
            string Owner = Properties.Settings.Default.UserName;
            bool fromSameID = db1.messages.Any((i) => i.text == text && i.fromU == fromID);

            switch (fromSameID)
            {
                case true:
                    return 20;
                case false:
                    return 100;
                default:
                    return 0;
            }


        }

        public Color setColor(string text)
        {
            int fromID = db1.users.Where((i) => i.UserName == mUsername).Select((i) => i.id).Single();
            int toID = db1.users.Where((i) => i.UserName == lblUserName.Text).Select((i) => i.id).Single();

            string sOwner = db1.messages.Where((i) => i.text == text && i.fromU == fromID && i.toU == toID).Select((i) => i.Owner).Single();

            if(sOwner == mUsername)
            {
                return Color.Blue;
            }
            else
            {
                return Color.FromArgb(60, 176, 67);
            }

        }

        public bool jeez(string text)
        {
            int fromID = db1.users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single();
            string Owner = Properties.Settings.Default.UserName;
            bool fromSameID = db1.messages.Any((i) => i.text == text && i.fromU == fromID);

            if (fromSameID)
                return true;

            return false;

        }

        public async Task ShowMessagesAsync()
        {
            textBox1.Clear();

            db dbMessages = new db();
            int fromID = new db().users.Where(i => i.UserName == Properties.Settings.Default.UserName).Select(i => i.id).Single();
            int toID = new db().users.Where(i => i.UserName == lblUserName.Text).Select(i => i.id).Single();

            // Use Task.Run for potentially slow database access in a background thread
            var MessagesTask = Task.Run(() =>
            {
                return dbMessages.messages.Where(i => i.fromU == fromID && i.toU == toID || i.fromU == toID && i.toU == fromID).ToList().OrderBy(i => i.datetime);
            });

            string query = $@"use messengerX_Test7

select * from Messages 
where fromU = {fromID} and toU = {toID} or fromU = {toID} and toU = {fromID}
order by datetime asc";

            // Use await for both database access and message processing
            var Messages1 = await MessagesTask;
            var Messages2 = dbMessages.Database.SqlQuery<Message>(query);

            string Owner = Properties.Settings.Default.UserName;

            int top = 10;

            foreach (var item in Messages1)
            {
                #region sample2 (assuming this is the chosen sample)
                MaterialCard CardMessage = new MaterialCard();
                Label text = new Label();
                Label Username = new Label();
                Username.Name = "button1";
                Username.Text = item.Owner;
                Username.AutoSize = true;
                Username.ForeColor = (item.Owner == Properties.Settings.Default.UserName) ? Color.Blue : Color.Red;
                Username.Font = new Font("Roboto", 13f);
                Username.Size = new Size(40, 40);
                Username.Location = new Point(1, 10);
                Username.Visible = true;
                CardMessage.Controls.Add(Username);

                text.Visible = true;
                text.Font = new Font("Roboto", 16f);
                text.Location = new Point(text.Location.X, MainY); // Assuming MainY is defined elsewhere
                text.ForeColor = Color.Black;
                text.AutoSize = true;
                CardMessage.Name = textBox1.Text;
                CardMessage.Size = new Size(193, 20);
                CardMessage.Location = new Point(80, 10 + top);
                CardMessage.BackColor = Color.Red;
                CardMessage.AutoSize = true;
                CardMessage.Visible = true;
                text.Text = item.text;
                panelMesssages.Controls.Add(CardMessage);
                CardMessage.Controls.Add(text);
                CardMessage.Tag = "Message";
                CardMessage.Padding = new Padding(15, 10, 15, 10);
                CardMessage.Margin = new Padding(10, 5, 10, 5);
                text.Tag = "Message";
                CardMessage.Top = top;

                CardMessage.Show();
                top += 80;
                // ... (rest of your code)

                #endregion
            }
        }

        public void ScrollToFirstMessage()
        {
            if (panelMesssages.Controls.Count == 0)
            {
                // Handle case with no controls in the panel (optional)
                return;
            }

            Control firstControl = panelMesssages.Controls[0];

            // Calculate the adjusted offset to avoid negative values
            int offset = Math.Max(0, firstControl.Top - firstControl.Margin.Top);

            // Check if currently scrolled above the first control
            bool alreadyAtTop = panelMesssages.VerticalScroll.Value <= offset;

            // Scroll if necessary, considering current position
            if (!alreadyAtTop)
            {
                panelMesssages.VerticalScroll.Value = offset;
            }
        }



        public string placeholderMessage = "  your Message...";


        string Username = MessengerWindow.UserName;
        string UserId = MessengerWindow.UserID;
        bool isonline = MessengerWindow.isOnline;
        Image ProfilePicture = MessengerWindow.ProfilePicture;

        public int? FrontUserMaxMessageID;
        public static string inUsername;
        private async void UserMessenger_Load(object sender, EventArgs e)
        {

           

            btnSend.Image = Image.FromFile("disable.png");
            btnSend.Enabled = false;



            panelMesssages.FlowDirection = FlowDirection.TopDown;



            // main verse
           try
            {
                db dbMessages = new db();

                lblUserName.Text = Username;
                lblisonline.Text = UserId;
                inUsername = lblUserName.Text;
                rjCircularPictureBox1.Image = ProfilePicture;

                ImageVerified.Hide();


                if (Username == "Mantounio")
                {
                    ImageVerified.Show();
                }

                if (isonline)
                    lblisonline.Text = "Online";
                else
                    lblisonline.Text = "Offline";


                // show the tool tip for the basic information

                toolTiphint.SetToolTip(ImageVerified, "Verified account");
                toolTiphint.SetToolTip(btnBlock, "Block user");
                toolTiphint.SetToolTip(btnClearMessage, "Clear messages");


                // the main part:

                //txtboxMessage.Text = placeholderMessage;
                //txtboxMessage.ForeColor = Color.FromArgb(198, 203, 207);

                // to show the messages

               

                 await ShowMessagesAsync();


            }
            catch
            {
                // Do nothing...
            }




            //ScrollToFirstMessage();
            scrollTolast();

            toUID = new db().users.Where((i) => i.UserName == lblUserName.Text).Select((i) => i.id).Single();
            fromID = new db().users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single();


            //timerReading.Start();
            try
            {
                FrontUserMaxMessageID = db1.messages.Where((i) => i.Owner == lblUserName.Text && i.id == db1.messages.Max((j) => j.id)).Select((i) => i.id).Single();

            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FrontUserMaxMessageID = 0;
                return;
            }

            






        }




        // blocking Users method


        public bool isBlocked(BlockedUsers BlockedUsers)
        {
            db dbBlocked = new db();

            bool val1 = dbBlocked.blockedUser.Any((i) => i.MainUserID == BlockedUsers.MainUserID && i.relatedID == BlockedUsers.relatedID);
            bool val2 = dbBlocked.blockedUser.Any((i) => i.MainUserID == BlockedUsers.relatedID && i.relatedID == BlockedUsers.MainUserID);

            return val1 && val2;
        }

        public void Block(BlockedUsers blockedUsers) // for a user
        {
           if(isBlocked(blockedUsers)!= true) // if it wasn't blocked
            {
                try
                {
                    db dbaddUserBlocked = new db();
                    dbaddUserBlocked.blockedUser.Add(blockedUsers);

                    dbaddUserBlocked.SaveChanges();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("this user already blocked!", "can't block user", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        


        public event EventHandler eventShowContacts;
       
        public void BlockUser()
        {
           try
            {
                db dbBlockUser = new db();

                int thisID = dbBlockUser.users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single();

                var requestedID = dbBlockUser.relations.Where((i) => i.MainUserID == thisID).Select((i) => i.requestedUserID).ToList();

                int UserID = dbBlockUser.users.Where((i) => i.UserName == lblUserName.Text).Select((i) => i.id).Single();

                var removingItem = dbBlockUser.relations.Where((i) => i.MainUserID == thisID && i.requestedUserID == UserID);
                var removingItem2 = dbBlockUser.relations.Where((i) => i.MainUserID == UserID && i.requestedUserID == thisID);




                foreach (var item in requestedID)
                {
                    if (item == UserID && removingItem.Count() == 1)
                    {
                        //removing data from relations

                        dbBlockUser.relations.Remove(removingItem.Single());
                        dbBlockUser.relations.Remove(removingItem2.Single());

                        // adding data to relations


                        Block(new BlockedUsers
                        {
                            MainUserID = thisID,
                            relatedID = UserID
                        });

                        Block(new BlockedUsers
                        {
                            MainUserID = UserID,
                            relatedID = thisID
                        });
                       

                        
                        dbBlockUser.SaveChanges();

                        eventShowContacts?.Invoke(this, EventArgs.Empty);
                      

                    }

                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

        private void lblUserName_Click(object sender, EventArgs e)
        {
            string UserID = new db().users.Where((i) => i.UserName == lblUserName.Text).Select((i) => i.UserIdentity).Single();
            Clipboard.SetText(UserID);

            MessageBox.Show("User ID copied to clipboard!", "User ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show($"Do you want to block {lblUserName.Text}","block user", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                BlockUser();
            }
            
        }

        public void ClearMessages()
        {
            db dbMessages = new db();

            int fromID = new db().users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single();
            int toID = new db().users.Where((i) => i.UserName == lblUserName.Text).Select((i) => i.id).Single();

            var Messages = dbMessages.messages.Where((i) => i.fromU == fromID && i.toU == toID || i.fromU == toID && i.toU == fromID).ToList();

            dbMessages.messages.RemoveRange(Messages);
            dbMessages.SaveChanges();


        }

        private void btnClearMessage_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("do you want to clear messages?","Clear messages", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearMessages();
                panelMesssages.Controls.Clear();
            }
            else
            {
                return;
            }

        }

       

        

        private void UserMessenger_Click(object sender, EventArgs e)
        {
            //this.ActiveControl = null;
            ////MessageBox.Show(txtboxMessage.Text,txtboxMessage.Text.Length.ToString());

            //if(txtboxMessage.Text == "  " || txtboxMessage.Text.Length == 2)
            //{
            //    txtboxMessage.ForeColor = Color.FromArgb(198, 203, 207);
            //    txtboxMessage.Text = placeholderMessage;

            //}


            this.ActiveControl = null;

            //deselectTxt();

            
        }

      

        private void materialCard1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            rjCircularPictureBox1.FindForm();

            //deselectTxt();
        }

       

     



        // Sending Message:
        public void sendMessage(Message Message)
        {
            db dbSendMessage = new db();
            try
            {
                dbSendMessage.messages.Add(Message);

                dbSendMessage.SaveChangesAsync();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void scrollTolast()
        {
           try
            {
                if (panelMesssages.Controls.Count > 0)
                {
                    // Get the latest added control (assuming new messages are added at the end)
                    Control lastControl = panelMesssages.Controls[panelMesssages.Controls.Count - 1];

                    // Check if the last control is visible on the current scroll position
                    if (!panelMesssages.ClientRectangle.Contains(lastControl.Bounds))
                    {
                        // Scroll to make the last control visible
                        panelMesssages.VerticalScroll.Value = panelMesssages.VerticalScroll.Maximum;
                    }
                }
            }
            catch
            {
                // Do nothing...
            }
        }


       


        // to seprate the Maines:
        
        

        int top = 10;

        public void enterSendmessage()
        {
            if(textBox1.Text == "who made app")
            {
                MessageBox.Show("the one who made this application is : Mantounio", "MessengerX Creator", MessageBoxButtons.OK, MessageBoxIcon.Information);return;
            }
            else if(textBox1.Text == "who made sfx")
            {
                MessageBox.Show("the one who made this application's sfx is : PsychoSymphony", "MessengerX sfx Designer", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            int fromID = new db().users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single();
            int toID = new db().users.Where((i) => i.UserName == lblUserName.Text).Select((i) => i.id).Single();
            string Owner = Properties.Settings.Default.UserName;

            sendMessage(new Message
            {
                text = textBox1.Text,
                fromU = fromID,
                toU = toID,
                datetime = DateTime.Now,
                Owner = Owner
            });



            MaterialCard CardMessage = new MaterialCard();
            Label text = new Label();
            Label Username = new Label();
            Username.Name = "button1";
            Username.Text = Properties.Settings.Default.UserName;
            Username.AutoSize = true;
            Username.ForeColor = Color.Blue;
            Username.Font = new Font("Roboto", 13f);
            Username.Size = new Size(40, 40);
            Username.Location = new Point(1, 10);
            Username.Visible = true;
            CardMessage.Controls.Add(Username);
            //Label indicator = new Label();
            //indicator.Name = textBox1.Text + " " + "User";
            //indicator.Text = Owner;//indicateUserName(textBox1.Text);
            //indicator.Visible = true;
            //indicator.AutoSize = true;
            //indicator.Font = PrioFont;
            //indicator.Size = new Size(15, 15);
            //indicator.Location = MainLocation;
            //indicator.ForeColor = Color.Blue;
            text.Visible = true;
            //CardMessage.Controls.Add(indicator);
            text.Font = new Font("Roboto", 16f);
            text.Location = new Point(text.Location.X, MainY);
            text.ForeColor = Color.Black;
            text.AutoSize = true;
            CardMessage.Name = textBox1.Text;
            CardMessage.Size = new Size(193, 20);
            CardMessage.Location = new Point(20, 10 + top);
            CardMessage.BackColor = Color.Red;
            CardMessage.AutoSize = true;
            text.Text = textBox1.Text;
            panelMesssages.Controls.Add(CardMessage);
            CardMessage.Controls.Add(text);
            CardMessage.Tag = "Message";
            CardMessage.Padding = new Padding(15, 10, 15, 10);
            CardMessage.Margin = new Padding(10, 5, 10, 5);

            text.Tag = "Message";
            CardMessage.Top = top;
            //RJCircularPictureBox Profiler = new RJCircularPictureBox();
            //Profiler.Left = CardMessage.Left;
            //Profiler.Image = MessengerWindow.ProfilePicture;
            //Profiler.Visible = true;
            //Profiler.Size = new Size(30, 30);
            //panelMesssages.Controls.Add(Profiler);




            CardMessage.Show();
            top += 80;

            textBox1.Clear();
            scrollTolast();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {


            enterSendmessage();


















        }

        private void panelMesssages_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        public static async Task PlayingSound(string sound)
        {
            SoundPlayer soundplayer = new SoundPlayer(sound);
            await Task.Run(()=>soundplayer.Play());    
        }

        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 0)
            {
                btnSend.Enabled = false;
                btnSend.Image = Image.FromFile("disable.png");

                //MessageBox.Show("disabled");
            }
            else if (textBox1.Text.Length != 0)
            {
                btnSend.Enabled = true;
                btnSend.Image = Image.FromFile("enabled.png");
                //MessageBox.Show("enabled");

            }


            // to say if the values is higher than a certain number like 70

            
        }

        private void UserMessenger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("sendingm messages");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                 
                    enterSendmessage();
                

                }
            }

        }
        PopupNotifier userNotification = new PopupNotifier();
        private async void timerReading_Tick(object sender, EventArgs e)
        {
            int count = await Task.Run(() => new db().messages.ToList().Count());
            Form MainWindowForm = (from i in Application.OpenForms.Cast<Form>() where i.Name == "MainWindow" select i).FirstOrDefault();


            if (count == 0)
            {
                return;
            }
            else
            {
                int FrontUserID = await Task.Run(()=>new db().users.Where((i) => i.UserName == lblUserName.Text).Select((i) => i.id).Single());
                int meUserID = await Task.Run(()=>new db().users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single());

                //MessageBox.Show(meUserID.ToString(), "my self"); //      2
                //MessageBox.Show(FrontUserID.ToString(), "my contact");//  1

                //int FronUserMaxMessageID = db1.messages.Where((i) => i.Owner == lblUserName.Text && i.id == db1.messages.Max((j)=>j.id)).Select((i) => i.id).Single();

                //MessageBox.Show(this.FrontUserMaxMessageID.ToString(), "Front user max message id");

                // after that

                //MessageBox.Show(getLatestMessage().id.ToString(), "latest message information");

                MainWindow mainwindow1 = new MainWindow();
                var getlatestmessage = getLatestMessage();
                if (getlatestmessage != null && getlatestmessage.id == this.FrontUserMaxMessageID)
                {
                    
                }
                else
                {
                    if(getlatestmessage != null &&getlatestmessage.Owner == lblUserName.Text)
                    {
                        if (MainWindowForm.WindowState == FormWindowState.Normal)
                        {
                            this.FrontUserMaxMessageID = getLatestMessage().id;


                            //MessageBox.Show(getLatestMessage().Owner);

                            #region crtBTn
                            MaterialCard CardMessage = new MaterialCard();
                            Label text = new Label();
                            Label Username = new Label();
                            Username.Name = "button1";
                            Username.Text = getLatestMessage().Owner;
                            Username.AutoSize = true;
                            Username.ForeColor = Color.Red;
                            Username.Font = new Font("Roboto", 13f);
                            Username.Size = new Size(40, 40);
                            Username.Location = new Point(1, 10);
                            Username.Visible = true;
                            CardMessage.Controls.Add(Username);

                            text.Visible = true;
                            //CardMessage.Controls.Add(indicator);
                            text.Font = new Font("Roboto", 16f);
                            text.Location = new Point(text.Location.X, MainY);
                            text.ForeColor = Color.Black;
                            text.AutoSize = true;
                            CardMessage.Name = getLatestMessage().text;
                            CardMessage.Size = new Size(193, 20);
                            CardMessage.Location = new Point(20, 10 + top);
                            CardMessage.BackColor = Color.Red;
                            CardMessage.AutoSize = true;
                            text.Text = getLatestMessage().text;
                            panelMesssages.Controls.Add(CardMessage);
                            CardMessage.Controls.Add(text);
                            CardMessage.Tag = "Message";
                            CardMessage.Padding = new Padding(15, 10, 15, 10);
                            CardMessage.Margin = new Padding(10, 5, 10, 5);

                            text.Tag = "Message";
                            CardMessage.Top = top;





                            CardMessage.Show();
                            top += 80;

                            #endregion

                            

                            notifMsg.Text = "a text";
                            notifMsg.Visible = true;
                            notifMsg.BalloonTipTitle = "toolTipIcon";
                            notifMsg.BalloonTipText = "tool tip text";
                            notifMsg.ShowBalloonTip(100);


                            // here should play some sound effects!

                            // migrate to minimize part


                            // find the MainWindow form to close it manually

                            // Playing notification Sound: (can comment it out)


                            scrollTolast();
                            if (Properties.Settings.Default.mustPlay == true)
                            {
                               if(this.Visible == true)
                                {
                                    string defaultSound = Properties.Settings.Default.soundName;
                                    await PlayingSound(defaultSound);
                                    return;
                                }

                            }

















                            



                        }
                        else if(MainWindowForm.WindowState == FormWindowState.Minimized)
                        {
                            userNotification.TitleText = getLatestMessage().Owner;
                            userNotification.ContentText = getLatestMessage().text;
                            userNotification.AnimationDuration = 1;
                            userNotification.BodyColor = Color.White;
                            userNotification.ContentFont = new Font("Tahoma", 14f);
                            userNotification.TitleFont = new Font("Tahoma", 16f);
                            userNotification.Image = rjCircularPictureBox1.Image;
                            userNotification.ImageSize = new Size(111, 111);
                            userNotification.Click += UserNotification_Click;
                            userNotification.Popup();

                            if (Properties.Settings.Default.mustPlay)
                            {
                                string defaultSound = Properties.Settings.Default.soundName;
                                await PlayingSound(defaultSound);
                            }


                        }
                    }
                }
            }
            

        }

        private void UserNotification_Click(object sender, EventArgs e)
        {
            Form MainWindowForm = (from i in Application.OpenForms.Cast<Form>() where i.Name == "MainWindow" select i).FirstOrDefault();
            MainWindowForm.WindowState = FormWindowState.Normal;
            userNotification.Hide();
        }

        public  async Task SendFrontmessage()
        {
            int FrontUserID = db1.users.Where((i) => i.UserName == lblUserName.Text).Select((i) => i.id).Single();
            int meUserID = db1.users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single();

            // for sending messages from Fronted User!
            db1.messages.Add(new Message
            {
                Owner = lblUserName.Text,
                datetime = DateTime.Now,
                text = "eren jeager" + " " + $"{toUID} {fromID}",
                fromU = FrontUserID,
                toU = meUserID
            });

            await db1.SaveChangesAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           await  SendFrontmessage();
        }

        public  Message getLatestMessage()
        {
            try { return db1.messages.ToList()[db1.messages.Count() - 1]; }
            catch { return null; }
        }

        int maxValueGlobal;

        private void button2_Click(object sender, EventArgs e)
        {
            // for checking for one time!



            int FrontUserID = db1.users.Where((i) => i.UserName == lblUserName.Text).Select((i) => i.id).Single();
            int meUserID = db1.users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single();

            MessageBox.Show(meUserID.ToString(), "my self"); //      2
            MessageBox.Show(FrontUserID.ToString(),"my contact");//  1

            //int FronUserMaxMessageID = db1.messages.Where((i) => i.Owner == lblUserName.Text && i.id == db1.messages.Max((j)=>j.id)).Select((i) => i.id).Single();

            MessageBox.Show(this.FrontUserMaxMessageID.ToString(),"Front user max message id");

            // after that

            MessageBox.Show(getLatestMessage().id.ToString(),"latest message information");

            if(getLatestMessage().id == this.FrontUserMaxMessageID)
            {
               
            }
            else
            {
                this.FrontUserMaxMessageID = getLatestMessage().id;
               
               




            }





        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //textBox1.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //deselectTxt();
        }

        private void panelMesssages_Click_1(object sender, EventArgs e)
        {
            ActiveControl = null;

            //deselectTxt();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            

        }

        private void notifMsg_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void UserMessenger_VisibleChanged(object sender, EventArgs e)
        {
            inUsername = string.Empty;
        }






        //private List<Message> FetchNewMessages(int fromID, int toUID, int lastMessageId)
        //{
        //    // Using Entity Framework syntax (replace with your actual implementation)
        //    return db1.messages
        //              .Where(i => i.fromU == fromID && i.toU == toUID && i.id > lastMessageId)
        //              .ToList();
        //}

    }





}


// Consider that you can add a button like back button to the main menu in the telegram android application so consider it that you can build a feature like this Consider it and after that consider that you can Use a kebab button and put that in the right of the user header bar and have options like block,clear chat and more features
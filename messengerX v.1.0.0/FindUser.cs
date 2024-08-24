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
using System.Text.RegularExpressions;
namespace messengerX_v._1._0._0
{
    public partial class FindUser : UserControl
    {
        db db1 = new db();

        public FindUser()
        {
            InitializeComponent();
        }

        public void setError(string errorMessage)
        {
            label3.Show();
            label3.Text = errorMessage;
            panel2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }


        public bool isBlocked()
        {
            db dbBlocked = new db();
            string findingUsername = Regex.Replace(textBox1.Text, "\\d", "");

           



         
            int thisid = dbBlocked.users.Where((i) => i.UserName == Properties.Settings.Default.UserName).Select((i) => i.id).Single();
            int searchedUserId = dbBlocked.users.Where((i) => i.UserName == findingUsername).Select((i) => i.id).Single();
            bool blockeduser = dbBlocked.blockedUser.Any((i) => i.MainUserID == thisid && i.relatedID == searchedUserId);

         

            return blockeduser;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty)
            {
                // TO FIND THE USER:
               try
                {
                   if(textBox1.Text != Properties.Settings.Default.UserIdentity)
                    {
                        if(isBlocked()!= true) // it means if the User was not blocked show it and let the user add it to their contacts
                        {
                            label3.Hide();
                            db dbSearch = new db();

                            string UserName = (from i in dbSearch.users where i.UserIdentity == textBox1.Text select i.UserName).Single();
                            string UserID = (from i in dbSearch.users where i.UserIdentity == textBox1.Text select i.UserIdentity).Single();
                            string JoinedTime = (from i in dbSearch.users where i.UserIdentity == textBox1.Text select i.RegisterTime).Single();
                            byte[] UserProfilePicture = (from i in dbSearch.users where i.UserIdentity == textBox1.Text select i.ProfilePicture).Single();

                            MemoryStream ReadingProfilePicture = new MemoryStream(UserProfilePicture);

                            Image image1 = Image.FromStream(ReadingProfilePicture);

                            lblUsername.Text = "User Name : " + UserName;
                            lblUserID.Text = "User ID : " + UserID;
                            lblRegisterTime.Text = $"Register Time : {JoinedTime}";// + Convert.ToDateTime(JoinedTime).Date;
                            rjCircularPictureBox1.Image = image1;

                            panel2.Show();
                        }
                        else
                        {
                            setError("this user is blocked!");
                        }

                    }
                   else
                    {
                        setError("use diffrent credentials!");
                    }
                }
                catch (Exception e1)
                {
                    if(e1.Message == "Sequence contains no elements")
                    {
                        setError("no matching user!");
                    }

                   
                }



                
            }
            else
            {
               //do nothing
            }
        }

        private void FindUser_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void FindUser_Load(object sender, EventArgs e)
        {
            //set tooltip for the userId label
            toolTip1.SetToolTip(label2, "you can see your ID in your profile!");
        }


        public bool Exist(Relations Relation)
        {
            db dbSearch = new db();

            var q = dbSearch.relations.Any((i) => i.MainUserID == Relation.MainUserID && i.requestedUserID == Relation.requestedUserID);
            return q;
        }


        public event EventHandler ShowcontactsEvent;


        public void AddContact(Relations relation)
        {
           if(Exist(relation)!= true) // it means if the relation isn't connected, connect a relation
            {
                try
                {
                    db dbRelation = new db();
                    dbRelation.relations.Add(relation);
                    dbRelation.SaveChanges();

                    ShowcontactsEvent?.Invoke(this, EventArgs.Empty);


                    

                    this.Hide();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           else // if it was true it means that the relation is connected so don't add it anymore
            {
                setError("this user already added !");
                return;
            }
           
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {
            db db1 = new db();

            int MainUserID = (from i in db1.users where i.UserName == Properties.Settings.Default.UserName select i.id).Single();
            int requestedUserId = (from i in db1.users where i.UserName == lblUsername.Text.Substring(11).TrimStart().TrimEnd() select i.id).Single();


            AddContact(new Relations
            {
                MainUserID = MainUserID,
                requestedUserID = requestedUserId

            });
            AddContact(new Relations
            {
                MainUserID = requestedUserId,
                requestedUserID = MainUserID
            });
        }
    }
}

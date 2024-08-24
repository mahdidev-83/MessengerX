using MaterialSkin.Controls;


namespace messengerX_v._1._0._0
{
    partial class MessengerWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessengerWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.rjCircularPictureBox2 = new CustomControls.CircularPicturebox.RJCircularPictureBox();
            this.rjCircularPictureBox1 = new CustomControls.CircularPicturebox.RJCircularPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeProfilePicture = new System.Windows.Forms.OpenFileDialog();
            this.toolTipProfile = new System.Windows.Forms.ToolTip(this.components);
            this.TimerShowContact = new System.Windows.Forms.Timer(this.components);
            this.TimerReadData = new System.Windows.Forms.Timer(this.components);
            this.in_notif = new System.Windows.Forms.Panel();
            this.lblContent = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.RjProfilePicture = new CustomControls.CircularPicturebox.RJCircularPictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.datagridBlockedUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox3 = new CustomControls.CircularPicturebox.RJCircularPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRegTime = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.lblId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblisOnline = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelMsg = new messengerX_v._1._0._0.FindUser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.in_notif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RjProfilePicture)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBlockedUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.rjCircularPictureBox2);
            this.panel1.Controls.Add(this.rjCircularPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 673);
            this.panel1.TabIndex = 3;
            this.panel1.VisibleChanged += new System.EventHandler(this.panel1_VisibleChanged);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(24, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 40);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rjCircularPictureBox2
            // 
            this.rjCircularPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.rjCircularPictureBox2.BorderColor = System.Drawing.Color.Red;
            this.rjCircularPictureBox2.BorderColor2 = System.Drawing.Color.Blue;
            this.rjCircularPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox2.BorderSize = 2;
            this.rjCircularPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjCircularPictureBox2.GradientAngle = 50F;
            this.rjCircularPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox2.Image")));
            this.rjCircularPictureBox2.Location = new System.Drawing.Point(5, 149);
            this.rjCircularPictureBox2.Name = "rjCircularPictureBox2";
            this.rjCircularPictureBox2.Size = new System.Drawing.Size(81, 81);
            this.rjCircularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rjCircularPictureBox2.TabIndex = 5;
            this.rjCircularPictureBox2.TabStop = false;
            this.rjCircularPictureBox2.Click += new System.EventHandler(this.rjCircularPictureBox2_Click);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(5, 64);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(81, 81);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 2;
            this.rjCircularPictureBox1.TabStop = false;
            this.rjCircularPictureBox1.Click += new System.EventHandler(this.rjCircularPictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(7, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "_________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(236, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(778, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "message someone and chat about anything you like!";
            // 
            // ChangeProfilePicture
            // 
            this.ChangeProfilePicture.FileName = "FileName";
            // 
            // TimerShowContact
            // 
            this.TimerShowContact.Interval = 1000;
            this.TimerShowContact.Tick += new System.EventHandler(this.TimerShowContact_Tick);
            // 
            // TimerReadData
            // 
            this.TimerReadData.Enabled = true;
            this.TimerReadData.Interval = 3000;
            this.TimerReadData.Tick += new System.EventHandler(this.TimerReadData_Tick);
            // 
            // in_notif
            // 
            this.in_notif.BackColor = System.Drawing.Color.White;
            this.in_notif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.in_notif.Controls.Add(this.lblContent);
            this.in_notif.Controls.Add(this.lbluser);
            this.in_notif.Controls.Add(this.RjProfilePicture);
            this.in_notif.Location = new System.Drawing.Point(777, 84);
            this.in_notif.Name = "in_notif";
            this.in_notif.Size = new System.Drawing.Size(512, 99);
            this.in_notif.TabIndex = 19;
            this.in_notif.Visible = false;
            this.in_notif.VisibleChanged += new System.EventHandler(this.in_notif_VisibleChanged);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(123, 54);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(123, 26);
            this.lblContent.TabIndex = 21;
            this.lblContent.Text = "UserName";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.Black;
            this.lbluser.Location = new System.Drawing.Point(122, 8);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(157, 35);
            this.lbluser.TabIndex = 20;
            this.lbluser.Text = "UserName";
            // 
            // RjProfilePicture
            // 
            this.RjProfilePicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.RjProfilePicture.BorderColor = System.Drawing.Color.Blue;
            this.RjProfilePicture.BorderColor2 = System.Drawing.Color.Blue;
            this.RjProfilePicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.RjProfilePicture.BorderSize = 2;
            this.RjProfilePicture.GradientAngle = 50F;
            this.RjProfilePicture.Location = new System.Drawing.Point(3, 3);
            this.RjProfilePicture.Name = "RjProfilePicture";
            this.RjProfilePicture.Size = new System.Drawing.Size(96, 96);
            this.RjProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RjProfilePicture.TabIndex = 20;
            this.RjProfilePicture.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.AutoScroll = true;
            this.materialCard1.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCard1.Controls.Add(this.datagridBlockedUsers);
            this.materialCard1.Controls.Add(this.label6);
            this.materialCard1.Controls.Add(this.button8);
            this.materialCard1.Controls.Add(this.button9);
            this.materialCard1.Controls.Add(this.button10);
            this.materialCard1.Controls.Add(this.button7);
            this.materialCard1.Controls.Add(this.button6);
            this.materialCard1.Controls.Add(this.button5);
            this.materialCard1.Controls.Add(this.label5);
            this.materialCard1.Controls.Add(this.rjCircularPictureBox3);
            this.materialCard1.Controls.Add(this.panel2);
            this.materialCard1.Controls.Add(this.lblRegTime);
            this.materialCard1.Controls.Add(this.lblUsername);
            this.materialCard1.Controls.Add(this.materialSwitch1);
            this.materialCard1.Controls.Add(this.lblId);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.materialComboBox1);
            this.materialCard1.Controls.Add(this.lblEmail);
            this.materialCard1.Controls.Add(this.lblisOnline);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(162, 142);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(964, 389);
            this.materialCard1.TabIndex = 20;
            // 
            // datagridBlockedUsers
            // 
            this.datagridBlockedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBlockedUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.datagridBlockedUsers.Location = new System.Drawing.Point(39, 784);
            this.datagridBlockedUsers.Name = "datagridBlockedUsers";
            this.datagridBlockedUsers.RowHeadersWidth = 51;
            this.datagridBlockedUsers.RowTemplate.Height = 24;
            this.datagridBlockedUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridBlockedUsers.Size = new System.Drawing.Size(310, 150);
            this.datagridBlockedUsers.TabIndex = 46;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 28);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.label6.Location = new System.Drawing.Point(25, 727);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 28);
            this.label6.TabIndex = 45;
            this.label6.Text = "Blocked Contacts:";
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(771, 638);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(159, 55);
            this.button8.TabIndex = 44;
            this.button8.Tag = "soundtag";
            this.button8.Text = "Jazz";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(388, 638);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(159, 55);
            this.button9.TabIndex = 43;
            this.button9.Tag = "soundtag";
            this.button9.Text = "Harp minor";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(25, 638);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(159, 55);
            this.button10.TabIndex = 42;
            this.button10.Tag = "soundtag";
            this.button10.Text = "Clara";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(771, 540);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 55);
            this.button7.TabIndex = 41;
            this.button7.Tag = "soundtag";
            this.button7.Text = "Synth";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(388, 540);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 55);
            this.button6.TabIndex = 40;
            this.button6.Tag = "soundtag";
            this.button6.Text = "Swing";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(25, 540);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 55);
            this.button5.TabIndex = 39;
            this.button5.Tag = "soundtag";
            this.button5.Text = "Pianosimo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 28);
            this.label5.TabIndex = 38;
            this.label5.Tag = "soundtag";
            this.label5.Text = "Notification Sound:";
            // 
            // rjCircularPictureBox3
            // 
            this.rjCircularPictureBox3.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.rjCircularPictureBox3.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox3.BorderColor2 = System.Drawing.Color.Blue;
            this.rjCircularPictureBox3.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox3.BorderSize = 2;
            this.rjCircularPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjCircularPictureBox3.GradientAngle = 50F;
            this.rjCircularPictureBox3.Location = new System.Drawing.Point(420, 32);
            this.rjCircularPictureBox3.Name = "rjCircularPictureBox3";
            this.rjCircularPictureBox3.Size = new System.Drawing.Size(100, 100);
            this.rjCircularPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox3.TabIndex = 6;
            this.rjCircularPictureBox3.TabStop = false;
            this.rjCircularPictureBox3.Click += new System.EventHandler(this.rjCircularPictureBox3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 80);
            this.panel2.TabIndex = 7;
            // 
            // lblRegTime
            // 
            this.lblRegTime.AutoSize = true;
            this.lblRegTime.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblRegTime.Location = new System.Drawing.Point(17, 258);
            this.lblRegTime.Name = "lblRegTime";
            this.lblRegTime.Size = new System.Drawing.Size(152, 28);
            this.lblRegTime.TabIndex = 10;
            this.lblRegTime.Text = "register Time:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblUsername.Location = new System.Drawing.Point(17, 146);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(128, 28);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "User name:";
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(755, 441);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(115, 37);
            this.materialSwitch1.TabIndex = 15;
            this.materialSwitch1.Text = "Enabled";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.Click += new System.EventHandler(this.materialSwitch1_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblId.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblId.Location = new System.Drawing.Point(17, 315);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(90, 28);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "UserID:";
            this.lblId.Click += new System.EventHandler(this.lblId_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(562, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "__________________________________________________";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 144;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Default",
            "Appear Offline"});
            this.materialComboBox1.Location = new System.Drawing.Point(258, 354);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(184, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 6;
            this.materialComboBox1.UseAccent = false;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblEmail.Location = new System.Drawing.Point(17, 202);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(175, 28);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Signed in Email:";
            // 
            // lblisOnline
            // 
            this.lblisOnline.AutoSize = true;
            this.lblisOnline.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.lblisOnline.Location = new System.Drawing.Point(17, 370);
            this.lblisOnline.Name = "lblisOnline";
            this.lblisOnline.Size = new System.Drawing.Size(99, 28);
            this.lblisOnline.TabIndex = 12;
            this.lblisOnline.Text = "isOnline:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F);
            this.label3.Location = new System.Drawing.Point(17, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "play sound when recieve messages:";
            // 
            // PanelMsg
            // 
            this.PanelMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.PanelMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMsg.Location = new System.Drawing.Point(94, 3);
            this.PanelMsg.Name = "PanelMsg";
            this.PanelMsg.Size = new System.Drawing.Size(1195, 670);
            this.PanelMsg.TabIndex = 16;
            this.PanelMsg.Visible = false;
            // 
            // MessengerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.in_notif);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelMsg);
            this.Name = "MessengerWindow";
            this.Size = new System.Drawing.Size(1288, 673);
            this.Load += new System.EventHandler(this.MessengerWindow_Load);
            this.Click += new System.EventHandler(this.lblUserId_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.in_notif.ResumeLayout(false);
            this.in_notif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RjProfilePicture)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBlockedUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomControls.CircularPicturebox.RJCircularPictureBox rjCircularPictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog ChangeProfilePicture;
        private FindUser PanelMsg;
        private System.Windows.Forms.ToolTip toolTipProfile;
        private System.Windows.Forms.Timer TimerShowContact;
        private System.Windows.Forms.Timer TimerReadData;
        private CustomControls.CircularPicturebox.RJCircularPictureBox RjProfilePicture;
        public System.Windows.Forms.Panel in_notif;
        public System.Windows.Forms.Label lblContent;
        public System.Windows.Forms.Label lbluser;
        private CustomControls.CircularPicturebox.RJCircularPictureBox rjCircularPictureBox1;
        private MaterialCard materialCard1;
        private CustomControls.CircularPicturebox.RJCircularPictureBox rjCircularPictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRegTime;
        private System.Windows.Forms.Label lblUsername;
        private MaterialSwitch materialSwitch1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label4;
        private MaterialComboBox materialComboBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblisOnline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView datagridBlockedUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
    }
}

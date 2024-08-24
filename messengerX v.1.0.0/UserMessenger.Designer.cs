using MaterialSkin.Controls;
namespace messengerX_v._1._0._0
{
    partial class UserMessenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMessenger));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnClearMessage = new System.Windows.Forms.PictureBox();
            this.btnBlock = new System.Windows.Forms.PictureBox();
            this.ImageVerified = new System.Windows.Forms.PictureBox();
            this.lblisonline = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.toolTiphint = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.PictureBox();
            this.panelMesssages = new System.Windows.Forms.FlowLayoutPanel();
            this.timerReading = new System.Windows.Forms.Timer(this.components);
            this.notifMsg = new System.Windows.Forms.NotifyIcon(this.components);
            this.rjCircularPictureBox1 = new CustomControls.CircularPicturebox.RJCircularPictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageVerified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnClearMessage);
            this.materialCard1.Controls.Add(this.btnBlock);
            this.materialCard1.Controls.Add(this.ImageVerified);
            this.materialCard1.Controls.Add(this.lblisonline);
            this.materialCard1.Controls.Add(this.rjCircularPictureBox1);
            this.materialCard1.Controls.Add(this.lblUserName);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(155, 36);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(15);
            this.materialCard1.Size = new System.Drawing.Size(902, 141);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.Click += new System.EventHandler(this.materialCard1_Click);
            // 
            // btnClearMessage
            // 
            this.btnClearMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearMessage.Image = ((System.Drawing.Image)(resources.GetObject("btnClearMessage.Image")));
            this.btnClearMessage.Location = new System.Drawing.Point(709, 50);
            this.btnClearMessage.Name = "btnClearMessage";
            this.btnClearMessage.Size = new System.Drawing.Size(32, 32);
            this.btnClearMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClearMessage.TabIndex = 5;
            this.btnClearMessage.TabStop = false;
            this.btnClearMessage.Click += new System.EventHandler(this.btnClearMessage_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlock.Image = ((System.Drawing.Image)(resources.GetObject("btnBlock.Image")));
            this.btnBlock.Location = new System.Drawing.Point(793, 50);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(32, 32);
            this.btnBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBlock.TabIndex = 1;
            this.btnBlock.TabStop = false;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // ImageVerified
            // 
            this.ImageVerified.Image = global::messengerX_v._1._0._0.Properties.Resources._9027473_verified_icon__2_;
            this.ImageVerified.Location = new System.Drawing.Point(361, 36);
            this.ImageVerified.Name = "ImageVerified";
            this.ImageVerified.Size = new System.Drawing.Size(32, 32);
            this.ImageVerified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImageVerified.TabIndex = 4;
            this.ImageVerified.TabStop = false;
            // 
            // lblisonline
            // 
            this.lblisonline.AutoSize = true;
            this.lblisonline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisonline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.lblisonline.Location = new System.Drawing.Point(197, 75);
            this.lblisonline.Name = "lblisonline";
            this.lblisonline.Size = new System.Drawing.Size(105, 25);
            this.lblisonline.TabIndex = 3;
            this.lblisonline.Text = "UserName";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserName.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(195, 35);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(152, 38);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 623);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1174, 47);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.Window;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.Location = new System.Drawing.Point(1129, 635);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(24, 24);
            this.btnSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSend.TabIndex = 2;
            this.btnSend.TabStop = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panelMesssages
            // 
            this.panelMesssages.AutoScroll = true;
            this.panelMesssages.Location = new System.Drawing.Point(0, 211);
            this.panelMesssages.Name = "panelMesssages";
            this.panelMesssages.Size = new System.Drawing.Size(1174, 407);
            this.panelMesssages.TabIndex = 5;
            this.panelMesssages.WrapContents = false;
            this.panelMesssages.Click += new System.EventHandler(this.panelMesssages_Click_1);
            // 
            // timerReading
            // 
            this.timerReading.Enabled = true;
            this.timerReading.Interval = 3000;
            this.timerReading.Tick += new System.EventHandler(this.timerReading_Tick);
            // 
            // notifMsg
            // 
            this.notifMsg.Text = "notifyIcon1";
            this.notifMsg.Visible = true;
            this.notifMsg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifMsg_MouseDoubleClick);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(53, 15);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(111, 111);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 1;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // UserMessenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panelMesssages);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.textBox1);
            this.Name = "UserMessenger";
            this.Size = new System.Drawing.Size(1174, 670);
            this.Load += new System.EventHandler(this.UserMessenger_Load);
            this.VisibleChanged += new System.EventHandler(this.UserMessenger_VisibleChanged);
            this.Click += new System.EventHandler(this.UserMessenger_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserMessenger_KeyPress);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageVerified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialCard materialCard1;
        private System.Windows.Forms.Label lblisonline;
        private CustomControls.CircularPicturebox.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.PictureBox ImageVerified;
        private System.Windows.Forms.PictureBox btnBlock;
        private System.Windows.Forms.PictureBox btnClearMessage;
        private System.Windows.Forms.ToolTip toolTiphint;
        private System.Windows.Forms.PictureBox btnSend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel panelMesssages;
        private System.Windows.Forms.Timer timerReading;
        private System.Windows.Forms.NotifyIcon notifMsg;
        public System.Windows.Forms.Label lblUserName;
    }
}

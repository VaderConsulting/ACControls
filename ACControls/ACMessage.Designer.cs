namespace VaderConsulting.ACControls
{
    partial class ACMessage
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
            this.Message = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.Expand = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.PictureBox();
            this.tmrDim = new System.Windows.Forms.Timer(this.components);
            this.OK = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Expand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Message.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Message.Location = new System.Drawing.Point(78, 29);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(140, 43);
            this.Message.TabIndex = 1;
            this.Message.Text = "Message";
            this.Message.MouseEnter += new System.EventHandler(this.Message_MouseEnter);
            this.Message.MouseLeave += new System.EventHandler(this.Message_MouseLeave);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeader.Location = new System.Drawing.Point(78, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(140, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Header";
            this.lblHeader.MouseEnter += new System.EventHandler(this.lblHeader_MouseEnter);
            this.lblHeader.MouseLeave += new System.EventHandler(this.lblHeader_MouseLeave);
            // 
            // Expand
            // 
            this.Expand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Expand.BackgroundImage = global::VaderConsulting.ACControls.Properties.Resources.supervista_general_v_bw_16;
            this.Expand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Expand.Location = new System.Drawing.Point(224, 34);
            this.Expand.Margin = new System.Windows.Forms.Padding(1);
            this.Expand.Name = "Expand";
            this.Expand.Size = new System.Drawing.Size(23, 23);
            this.Expand.TabIndex = 6;
            this.Expand.TabStop = false;
            this.Expand.Click += new System.EventHandler(this.Expand_Click);
            this.Expand.MouseEnter += new System.EventHandler(this.Expand_MouseEnter);
            this.Expand.MouseLeave += new System.EventHandler(this.Expand_MouseLeave);
            // 
            // Logo
            // 
            this.Logo.Location = new System.Drawing.Point(3, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(69, 69);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.MouseEnter += new System.EventHandler(this.Logo_MouseEnter);
            this.Logo.MouseLeave += new System.EventHandler(this.Logo_MouseLeave);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackgroundImage = global::VaderConsulting.ACControls.Properties.Resources.supervista_general_cross_bw_16;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close.Location = new System.Drawing.Point(224, 5);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 4;
            this.Close.TabStop = false;
            this.Close.Visible = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // tmrDim
            // 
            this.tmrDim.Tick += new System.EventHandler(this.tmrDim_Tick);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OK.Location = new System.Drawing.Point(78, 76);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(66, 35);
            this.OK.TabIndex = 7;
            this.OK.Text = "OK";
            this.OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Cancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancel.Location = new System.Drawing.Point(172, 76);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(66, 35);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Cancel";
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ACMessage
            // 
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Expand);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.lblHeader);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(800, 120);
            this.MinimumSize = new System.Drawing.Size(250, 76);
            this.Size = new System.Drawing.Size(250, 76);
            this.MouseEnter += new System.EventHandler(this.ACMessage_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ACMessage_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.Expand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label Message;
        public System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.PictureBox Expand;
        private System.Windows.Forms.Timer tmrDim;
        private System.Windows.Forms.Label OK;
        private System.Windows.Forms.Label Cancel;
    }
}

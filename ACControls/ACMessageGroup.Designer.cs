namespace VaderConsulting.ACControls
{
    partial class ACMessageGroup
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
            this.GroupName = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.PictureBox();
            this.Image = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.tmrDim = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupName
            // 
            this.GroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupName.Location = new System.Drawing.Point(44, 0);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(318, 34);
            this.GroupName.TabIndex = 0;
            this.GroupName.Text = "GroupName";
            this.GroupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GroupName.MouseEnter += new System.EventHandler(this.GroupName_MouseEnter);
            this.GroupName.MouseLeave += new System.EventHandler(this.GroupName_MouseLeave);
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Location = new System.Drawing.Point(3, 41);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(401, 353);
            this.Panel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(401, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackgroundImage = global::VaderConsulting.ACControls.Properties.Resources.supervista_general_cross_bw_16;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close.Location = new System.Drawing.Point(368, 8);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 3;
            this.Close.TabStop = false;
            this.Close.Visible = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(4, 0);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(34, 34);
            this.Image.TabIndex = 2;
            this.Image.TabStop = false;
            this.Image.MouseEnter += new System.EventHandler(this.Image_MouseEnter);
            this.Image.MouseLeave += new System.EventHandler(this.Image_MouseLeave);
            // 
            // Header
            // 
            this.Header.Controls.Add(this.Close);
            this.Header.Controls.Add(this.Image);
            this.Header.Controls.Add(this.GroupName);
            this.Header.Location = new System.Drawing.Point(3, 3);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(404, 37);
            this.Header.TabIndex = 5;
            this.Header.MouseEnter += new System.EventHandler(this.Header_MouseEnter);
            this.Header.MouseLeave += new System.EventHandler(this.Header_MouseLeave);
            // 
            // tmrDim
            // 
            this.tmrDim.Tick += new System.EventHandler(this.tmrDim_Tick);
            // 
            // ACMessageGroup
            // 
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Header);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Panel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(250, 100);
            this.Name = "ACMessageGroup";
            this.Size = new System.Drawing.Size(407, 434);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ACMessageGroup_ControlAdded);
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label GroupName;
        private System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Timer tmrDim;
    }
}

namespace VaderConsulting.ACControls
{
    partial class ActionCentre
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
            this.Title = new System.Windows.Forms.Label();
            this.ClearAll = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(4, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(319, 41);
            this.Title.TabIndex = 0;
            this.Title.Text = "ACTION CENTRE";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClearAll
            // 
            this.ClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAll.BackColor = System.Drawing.Color.Transparent;
            this.ClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ClearAll.Location = new System.Drawing.Point(329, 6);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(68, 39);
            this.ClearAll.TabIndex = 1;
            this.ClearAll.Text = "Clear all";
            this.ClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            this.ClearAll.MouseEnter += new System.EventHandler(this.ClearAll_MouseEnter);
            this.ClearAll.MouseLeave += new System.EventHandler(this.ClearAll_MouseLeave);
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Location = new System.Drawing.Point(1, 48);
            this.Panel.Margin = new System.Windows.Forms.Padding(1);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(396, 203);
            this.Panel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(9, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Group";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ActionCentre
            // 
            this.AutoSize = true;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(400, 0);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "ActionCentre";
            this.Size = new System.Drawing.Size(400, 302);
            this.ParentChanged += new System.EventHandler(this.ActionCentre_ParentChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ClearAll;
        public System.Windows.Forms.FlowLayoutPanel Panel;
        private System.Windows.Forms.Button button1;
    }
}

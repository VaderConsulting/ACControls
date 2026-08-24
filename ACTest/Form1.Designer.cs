namespace ACTest
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel = new System.Windows.Forms.Panel();
            this.btnAddAC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.Location = new System.Drawing.Point(19, 19);
            this.Panel.Name = "Panel";
            this.Panel.Padding = new System.Windows.Forms.Padding(5);
            this.Panel.Size = new System.Drawing.Size(710, 760);
            this.Panel.TabIndex = 0;
            // 
            // btnAddAC
            // 
            this.btnAddAC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAC.AutoSize = true;
            this.btnAddAC.Location = new System.Drawing.Point(12, 791);
            this.btnAddAC.Name = "btnAddAC";
            this.btnAddAC.Size = new System.Drawing.Size(100, 39);
            this.btnAddAC.TabIndex = 1;
            this.btnAddAC.Text = "Add AC";
            this.btnAddAC.UseVisualStyleBackColor = true;
            this.btnAddAC.Click += new System.EventHandler(this.btnAddAC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(748, 842);
            this.Controls.Add(this.btnAddAC);
            this.Controls.Add(this.Panel);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button btnAddAC;

        #endregion

        //private ACControls.AC ac1;
        //private ACControls.ACMessageGroup acMessageGroup3;
        //private ACControls.ACMessageGroup acMessageGroup1;
        //private ACControls.ACMessage acMessage1;
    }
}


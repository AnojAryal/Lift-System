namespace ElevatorControlApp
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
            this.mainForm1 = new ElevatorControlApp.MainForm();
            this.mainForm2 = new ElevatorControlApp.MainForm();
            this.SuspendLayout();
            // 
            // mainForm1
            // 
            this.mainForm1.Location = new System.Drawing.Point(646, 652);
            this.mainForm1.Name = "mainForm1";
            this.mainForm1.Size = new System.Drawing.Size(696, 665);
            this.mainForm1.TabIndex = 0;
            // 
            // mainForm2
            // 
            this.mainForm2.Location = new System.Drawing.Point(646, -27);
            this.mainForm2.Name = "mainForm2";
            this.mainForm2.Size = new System.Drawing.Size(705, 673);
            this.mainForm2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1474, 804);
            this.Controls.Add(this.mainForm2);
            this.Controls.Add(this.mainForm1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ElevatorDesign";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MainForm mainForm1;
        private MainForm mainForm2;
    }
}


using LiftSystemApp.Views;

namespace LiftSystemApp
{
    partial class LiftFloors
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userControl11 = new Floor1();
            userControl12 = new Floor2();
            SuspendLayout();
            // 
            // userControl11
            // 
            userControl11.Location = new Point(1, 847);
            userControl11.Margin = new Padding(6, 8, 6, 8);
            userControl11.Name = "userControl11";
            userControl11.Size = new Size(775, 837);
            userControl11.TabIndex = 0;
            userControl11.Load += userControl11_Load;
            // 
            // userControl12
            // 
            userControl12.Location = new Point(1, 0);
            userControl12.Margin = new Padding(6, 8, 6, 8);
            userControl12.Name = "userControl12";
            userControl12.Size = new Size(765, 837);
            userControl12.TabIndex = 1;
            userControl12.Load += userControl12_Load_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1409, 1050);
            Controls.Add(userControl12);
            Controls.Add(userControl11);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Lift System";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Floor1 userControl11;
        private Floor2 userControl12;
    }
}
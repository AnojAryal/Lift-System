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
            mainDisplay1 = new Floor1();
            mainDisplay2 = new Floor2();
            logsButton = new Button();
            logsDisplay = new ListBox();
            SuspendLayout();
            // 
            // mainDisplay1
            // 
            mainDisplay1.Location = new Point(1, 847);
            mainDisplay1.Margin = new Padding(6, 8, 6, 8);
            mainDisplay1.Name = "mainDisplay1";
            mainDisplay1.Size = new Size(775, 837);
            mainDisplay1.TabIndex = 0;
            mainDisplay1.Load += userControl11_Load;
            // 
            // mainDisplay2
            // 
            mainDisplay2.Location = new Point(1, 0);
            mainDisplay2.Margin = new Padding(6, 8, 6, 8);
            mainDisplay2.Name = "mainDisplay2";
            mainDisplay2.Size = new Size(765, 837);
            mainDisplay2.TabIndex = 1;
            mainDisplay2.Load += userControl12_Load_1;
            // 
            // logsButton
            // 
            logsButton.Location = new Point(1030, 49);
            logsButton.Name = "logsButton";
            logsButton.Size = new Size(155, 67);
            logsButton.TabIndex = 2;
            logsButton.Text = "Show Logs";
            logsButton.UseVisualStyleBackColor = true;
            logsButton.Click += logsButton_Click;
            // 
            // logsDisplay
            // 
            logsDisplay.FormattingEnabled = true;
            logsDisplay.HorizontalScrollbar = true;
            logsDisplay.ItemHeight = 25;
            logsDisplay.Location = new Point(825, 132);
            logsDisplay.Name = "logsDisplay";
            logsDisplay.ScrollAlwaysVisible = true;
            logsDisplay.Size = new Size(546, 529);
            logsDisplay.TabIndex = 3;
            logsDisplay.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // LiftFloors
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1480, 1050);
            Controls.Add(logsDisplay);
            Controls.Add(logsButton);
            Controls.Add(mainDisplay2);
            Controls.Add(mainDisplay1);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LiftFloors";
            Text = "Lift System";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Floor1 mainDisplay1;
        private Floor2 mainDisplay2;
        private Button logsButton;
        private ListBox logsDisplay;
    }
}
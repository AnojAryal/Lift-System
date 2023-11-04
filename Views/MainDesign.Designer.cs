namespace LiftSystemApp
{
    partial class MainDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDesign));
            LiftDesign = new PictureBox();
            leftDoor = new PictureBox();
            rightDoor = new PictureBox();
            liftButton = new PictureBox();
            btnF1 = new PictureBox();
            btnF2 = new PictureBox();
            floorDisplay = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LiftDesign).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftDoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightDoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)liftButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnF1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnF2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)floorDisplay).BeginInit();
            SuspendLayout();
            // 
            // LiftDesign
            // 
            LiftDesign.Image = (Image)resources.GetObject("LiftDesign.Image");
            LiftDesign.Location = new Point(153, 5);
            LiftDesign.Margin = new Padding(4, 5, 4, 5);
            LiftDesign.Name = "LiftDesign";
            LiftDesign.Size = new Size(509, 812);
            LiftDesign.SizeMode = PictureBoxSizeMode.StretchImage;
            LiftDesign.TabIndex = 0;
            LiftDesign.TabStop = false;
            LiftDesign.Click += liftCart_Click;
            // 
            // leftDoor
            // 
            leftDoor.Image = (Image)resources.GetObject("leftDoor.Image");
            leftDoor.Location = new Point(246, 126);
            leftDoor.Margin = new Padding(4, 5, 4, 5);
            leftDoor.Name = "leftDoor";
            leftDoor.Size = new Size(166, 611);
            leftDoor.SizeMode = PictureBoxSizeMode.StretchImage;
            leftDoor.TabIndex = 1;
            leftDoor.TabStop = false;
            leftDoor.Click += pictureBox2_Click;
            // 
            // rightDoor
            // 
            rightDoor.Image = (Image)resources.GetObject("rightDoor.Image");
            rightDoor.Location = new Point(408, 126);
            rightDoor.Margin = new Padding(4, 5, 4, 5);
            rightDoor.Name = "rightDoor";
            rightDoor.Size = new Size(163, 611);
            rightDoor.SizeMode = PictureBoxSizeMode.StretchImage;
            rightDoor.TabIndex = 2;
            rightDoor.TabStop = false;
            rightDoor.Click += rightDoor_Click;
            // 
            // liftButton
            // 
            liftButton.Image = (Image)resources.GetObject("liftButton.Image");
            liftButton.Location = new Point(670, 404);
            liftButton.Margin = new Padding(4, 5, 4, 5);
            liftButton.Name = "liftButton";
            liftButton.Size = new Size(69, 70);
            liftButton.SizeMode = PictureBoxSizeMode.StretchImage;
            liftButton.TabIndex = 3;
            liftButton.TabStop = false;
            liftButton.Click += pictureBox4_Click;
            // 
            // btnF1
            // 
            btnF1.Image = (Image)resources.GetObject("btnF1.Image");
            btnF1.Location = new Point(263, 434);
            btnF1.Margin = new Padding(4, 5, 4, 5);
            btnF1.Name = "btnF1";
            btnF1.Size = new Size(36, 40);
            btnF1.SizeMode = PictureBoxSizeMode.StretchImage;
            btnF1.TabIndex = 5;
            btnF1.TabStop = false;
            btnF1.Click += pictureBox1_Click;
            // 
            // btnF2
            // 
            btnF2.Image = (Image)resources.GetObject("btnF2.Image");
            btnF2.Location = new Point(265, 384);
            btnF2.Margin = new Padding(4, 5, 4, 5);
            btnF2.Name = "btnF2";
            btnF2.Size = new Size(34, 40);
            btnF2.SizeMode = PictureBoxSizeMode.StretchImage;
            btnF2.TabIndex = 6;
            btnF2.TabStop = false;
            btnF2.Click += pictureBox2_Click_1;
            // 
            // floorDisplay
            // 
            floorDisplay.Image = Properties.Resources.indicator_floor1;
            floorDisplay.Location = new Point(352, 29);
            floorDisplay.Margin = new Padding(4, 5, 4, 5);
            floorDisplay.Name = "floorDisplay";
            floorDisplay.Size = new Size(138, 41);
            floorDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            floorDisplay.TabIndex = 7;
            floorDisplay.TabStop = false;
            floorDisplay.Click += indicator_Click;
            // 
            // MainDesign
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rightDoor);
            Controls.Add(leftDoor);
            Controls.Add(btnF1);
            Controls.Add(btnF2);
            Controls.Add(liftButton);
            Controls.Add(floorDisplay);
            Controls.Add(LiftDesign);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainDesign";
            Size = new Size(1301, 837);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)LiftDesign).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftDoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightDoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)liftButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnF1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnF2).EndInit();
            ((System.ComponentModel.ISupportInitialize)floorDisplay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox LiftDesign;
        private PictureBox leftDoor;
        private PictureBox rightDoor;
        private PictureBox liftButton;
        private PictureBox btnF1;
        private PictureBox btnF2;
        private PictureBox floorDisplay;

        public PictureBox UpButton => liftButton;
        public PictureBox Floor1Button => btnF1;
        public PictureBox Floor2Button => btnF2;
        public PictureBox Indicator => floorDisplay;





    }
}

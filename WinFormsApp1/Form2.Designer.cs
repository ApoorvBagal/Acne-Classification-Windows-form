namespace WinFormsApp1
{
    partial class Form2
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
            Pic1 = new PictureBox();
            Pic2 = new PictureBox();
            BtnStart = new Button();
            BtnCapture = new Button();
            ((System.ComponentModel.ISupportInitialize)Pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic2).BeginInit();
            SuspendLayout();
            // 
            // Pic1
            // 
            Pic1.Location = new Point(56, 36);
            Pic1.Name = "Pic1";
            Pic1.Size = new Size(200, 192);
            Pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic1.TabIndex = 0;
            Pic1.TabStop = false;
            // 
            // Pic2
            // 
            Pic2.Location = new Point(530, 36);
            Pic2.Name = "Pic2";
            Pic2.Size = new Size(202, 192);
            Pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic2.TabIndex = 1;
            Pic2.TabStop = false;
            // 
            // BtnStart
            // 
            BtnStart.Location = new Point(103, 272);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(94, 29);
            BtnStart.TabIndex = 2;
            BtnStart.Text = "start";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // BtnCapture
            // 
            BtnCapture.Location = new Point(584, 272);
            BtnCapture.Name = "BtnCapture";
            BtnCapture.Size = new Size(94, 29);
            BtnCapture.TabIndex = 3;
            BtnCapture.Text = "Capture";
            BtnCapture.UseVisualStyleBackColor = true;
            BtnCapture.Click += BtnCapture_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCapture);
            Controls.Add(BtnStart);
            Controls.Add(Pic2);
            Controls.Add(Pic1);
            Name = "Form2";
            Text = " ";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)Pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Pic1;
        private PictureBox Pic2;
        private Button BtnStart;
        private Button BtnCapture;
    }
}
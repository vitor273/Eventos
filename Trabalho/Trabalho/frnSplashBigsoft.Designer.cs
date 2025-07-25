namespace Trabalho
{
    partial class frnSplashBigsoft
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
            metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // metroToolTip1
            // 
            metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            metroToolTip1.StyleManager = null;
            metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gatoemo;
            pictureBox1.Location = new Point(126, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 347);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(274, 413);
            label1.Name = "label1";
            label1.Size = new Size(259, 28);
            label1.TabIndex = 1;
            label1.Text = "Produced by BigSoft";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(341, 9);
            label2.Name = "label2";
            label2.Size = new Size(117, 35);
            label2.TabIndex = 2;
            label2.Text = "@Pintest";
            label2.Click += label2_Click;
            // 
            // frnSplashBigsoft
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frnSplashBigsoft";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frnSplashBigsoft";
            Load += frnSplashBigsoft_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
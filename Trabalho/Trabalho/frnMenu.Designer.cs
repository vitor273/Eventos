namespace Trabalho
{
    partial class frnMenu
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
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.ícone_do_botão_desligar_ou_desativar_isolado_em_fundo_branco_de_cor_232846136_removebg_preview;
            pictureBox2.Location = new Point(437, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(503, 311);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "SAIR";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.galeria_removebg_preview;
            pictureBox3.Location = new Point(170, 141);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(179, 155);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(217, 311);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 4;
            label3.Text = "GALERIA";
            // 
            // frnMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frnMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frnMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label3;
    }
}
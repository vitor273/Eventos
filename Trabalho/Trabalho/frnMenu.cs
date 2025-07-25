namespace Trabalho
{
    public partial class frnMenu : Form
    {
        public frnMenu()
        {
            InitializeComponent();
        }


        private void frnMenu_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            frnSplash splach = new frnSplash();
            splach.Show();
            Application.DoEvents();
            Thread.Sleep(1500);
            splach.Close();

            InitializeComponent();
            frnSplashBigsoft splash = new frnSplashBigsoft();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(1500);
            splash.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (Form formAberto in Application.OpenForms)
                if (formAberto is frnGaleria)
                {
                    formAberto.Focus();
                    return;
                }
            frnGaleria galeria = new frnGaleria();
            galeria.Show();
            Cursor = Cursors.Default;
        }
    }
}
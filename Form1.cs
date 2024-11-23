namespace WinFormPictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOtonio_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WinFormPictureBox.Properties.Resources.Otoño;
        }

        private void btnInvierno_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WinFormPictureBox.Properties.Resources.Invierno;
        }

        private void btnVerano_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WinFormPictureBox.Properties.Resources.Verano;
        }

        private void btnPrimavera_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WinFormPictureBox.Properties.Resources.Primavera;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace aplicacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (msgExit.Show("Estas seguro que deseas salir?", "Advertencia!") == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Moto moto = new Moto();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Barco barco = new Barco();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion();
        }

    }
}
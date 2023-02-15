namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TXBdescuento.Enabled = false;
            TXBtotal.Enabled = false;
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            MASKEDventa.Text = "0";
            TXBdescuento.Text = "";
            TXBtotal.Text = "";
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
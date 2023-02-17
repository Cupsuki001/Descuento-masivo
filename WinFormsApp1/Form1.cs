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
            MASKEDventa.Text = "";
            TXBdescuento.Text = "";
            TXBtotal.Text = "";
            label5.Text = "NINGUNO";
            CHKBXdescuento.Checked = false;
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNcalcular_Click(object sender, EventArgs e)
        {
            double por , tot;

            if(MASKEDventa.Text == "") 
            {
                MessageBox.Show("EL SUBTOTAL NO PUEDE ESTAR EN BLANCO");
                MASKEDventa.Focus();
            }
            else
            {
                double venta = Convert.ToDouble(MASKEDventa.Text);
                if (CHKBXdescuento.Checked == true) 
                {
                    if (TREEVfactura.SelectedNode.Text.Equals("Credito"))
                    {
                        por = venta * 0.05;
                        tot = venta - por;

                        TXBdescuento.Text = por.ToString();
                        TXBtotal.Text = tot.ToString();
                        MessageBox.Show("El pago se ha realizado con exito :)");

                    }
                    else if (TREEVfactura.SelectedNode.Text.Equals("Contado"))
                    {
                        if (venta >= 1 && venta <= 200)
                        {
                            por = venta * 0.03;
                            tot = venta - por;
                            
                            TXBdescuento.Text = por.ToString();
                            TXBtotal.Text = tot.ToString();
                            MessageBox.Show("El pago se ha realizado con exito :)");
                        }
                        else if (venta >= 201 && venta <= 400)
                        {
                            por = venta * 0.05;
                            tot = venta - por;
                           
                            TXBdescuento.Text = por.ToString();
                            TXBtotal.Text = tot.ToString();
                            MessageBox.Show("El pago se ha realizado con exito :)");
                        }
                        else if (venta >= 401 && venta <= 500)
                        {
                            por = venta * 0.05;
                            tot = venta - por;
                            
                            TXBdescuento.Text = por.ToString();
                            TXBtotal.Text = tot.ToString();
                            MessageBox.Show("El pago se ha realizado con exito :)");
                        }
                        else
                        {
                            MessageBox.Show("EL SUBTOTAL NO PUEDE SER 0 NI MAYOR A 500");
                            MASKEDventa.Text = "";
                            MASKEDventa.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("INGRESE UN METODO DE PAGO");
                    }
                }
                else 
                {
                    
                    por = 0;
                    tot = venta;

                    TXBdescuento.Text = por.ToString();
                    TXBtotal.Text = tot.ToString();
                    MessageBox.Show("El pago se ha realizado con exito :)");
                } 
            }
           
        }

        private void TREEVfactura_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (TREEVfactura.SelectedNode.Text.Equals("Credito"))
            {
                label5.Text = "CREDITO";
            }
            else if (TREEVfactura.SelectedNode.Text.Equals("Contado"))
            {
                label5.Text = "CONTADO";
            }
           
        }
    }
}
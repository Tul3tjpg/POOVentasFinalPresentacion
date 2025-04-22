namespace POOVentasFinal
{
    class FormaPagoEfectivo : IFormaPago
    {
        public void Cobrar(decimal total)
        {
            MessageBox.Show("El total se pago en efectivo!");
        }
    }
}

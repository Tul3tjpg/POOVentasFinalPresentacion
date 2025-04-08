namespace POOVentasFinal
{
    internal abstract class Venta
    {
        public decimal Total 
        { 
            get 
            {
                return CalcularTotal();
            } 
        }
        //Creación de lista
        public List<ConceptoVenta> Conceptos { get; set; } = [];

        public decimal CalcularTotal() 
        {
            decimal total = 0.00m;
            foreach (ConceptoVenta concepto in Conceptos) 
            {
                total += concepto.Importe;
            }
            return total;
        }
    }
}

﻿namespace POOVentasFinal
{
    internal abstract class Venta
    {
        public decimal Total { get; set; }
        //Creación de lista
        List<ConceptoVenta> Conceptos { get; set; } = new List<ConceptoVenta>();
    }
}

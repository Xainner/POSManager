namespace BusinessLibrary.Models
{
    public class ProductsXInvoiceModel
    {
        public int IdDetailExternalInvoiceSell { get; set; }
        public int Product_idProduct { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
    }
}

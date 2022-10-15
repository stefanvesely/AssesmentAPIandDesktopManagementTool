namespace FullProductAssesment.DTO
{
    public class AddSalesDTO
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }
    }
}

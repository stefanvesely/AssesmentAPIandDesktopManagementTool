using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullProductAssesment.DataModels
{
    public class SalesModel
    {
        [Required]
        [Key]
        public int SaleId { get; set; }
        [Required]
        public int ProductId{ get; set; }
        [Required]
        public int StoreId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime SaleDate { get; set; }

        [ForeignKey("ProductId")]
        public virtual ProductModel ProductModel { get; set; }
        [ForeignKey("StoreId")]
        public virtual StoreModel StoreModel { get; set; }
    }
}

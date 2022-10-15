using System.ComponentModel.DataAnnotations;

namespace FullProductAssesment.DataModels
{
    public class ProductModel
    {
        [Required]
        [Key]
        public int ProductID{ get; set; }
        [Required]
        public string ProductName{ get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public bool Active { get; set; }
    }
}

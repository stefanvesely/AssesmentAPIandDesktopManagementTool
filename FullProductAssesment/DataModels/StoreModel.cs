using System.ComponentModel.DataAnnotations;

namespace FullProductAssesment.DataModels
{
    public class StoreModel
    {
        [Required]
        [Key]
        public int StoreID { get; set; }
        [Required]
        public string StoreName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        [Required]
        public bool Active { get; set; }
    }
}

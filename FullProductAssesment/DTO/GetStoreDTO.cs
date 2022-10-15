using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace FullProductAssesment.DTO
{
    public class GetStoreDTO
    {
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public bool Active { get; set; }
    }
}

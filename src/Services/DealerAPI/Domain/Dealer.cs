using System.ComponentModel.DataAnnotations;

namespace DealerAPI.Domain
{
    public class Dealer
    {
        [Key]
        public int Id { get; set; }
        
        // Nome fantasia
        [Required]
        public string TradingName { get; set; }
        
        //Razão Social
        [Required]
        public string CompanyName { get; set; }
        
        public string ImageUrl { get; set; }
        
        [Required]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$")]
        public string Cnpj { get; set; }
        
        [Required]
        [RegularExpression(@"^\d{5}\-\d{3}$")]
        public string Cep { get; set; }
        
        [Required] 
        public string Address { get; set; }
        
        [Required]
        public int AddressNumber { get; set; }
        
        [Required]
        [StringLength(100)]
        public string AddressComplement { get; set; }
        
        [Required]
        public string District { get; set; }
        
        [Required]
        public string Uf { get; set; }
        
        [Required]
        public string City { get; set; }
        
        [Required]
        public string OwnerName { get; set; }
        
        [Required]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$")]
        public string OwnerCpf { get; set; }
        
        [Required]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$")]
        public string DealerEmail { get; set; }
        
        [Required]
        [RegularExpression(@"^((https?):\/\/)?(www.)?[a-z0-9]+\.[a-z]+(\/[a-zA-Z0-9#]+\/?)*$")]
        public string DealerWebsite { get; set; }
    }
}
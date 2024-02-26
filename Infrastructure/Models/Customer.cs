using System.ComponentModel.DataAnnotations;

namespace CustomerInformationTracker.Infrastructure.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(20)]
        public string TelephoneNumber { get; set; }

        [StringLength(100)]
        public string ContactPersonName { get; set; }

        [EmailAddress]
        [StringLength(100)]
        public string ContactPersonEmailAddress { get; set; }

        [StringLength(20)]
        public string VATNumber { get; set; }
    }

}

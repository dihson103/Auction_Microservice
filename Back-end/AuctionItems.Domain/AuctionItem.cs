using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionItems.Domain
{
    public class AuctionItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuctionId { get; set; }
        public string? WinnerUserId { get; set; }
        [Required]
        public string LicensePlate { get; set; }
        [Required]
        public DateTime StartDateTime { get; set; }
        [Required]
        public DateTime EndDateTime { get; set; }
        [Required]
        public decimal StartingPrice { get; set; }
        [Required]
        public decimal MinAmountIncrease { get; set;}
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string KindOfCar { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string LicenseType { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string City { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}

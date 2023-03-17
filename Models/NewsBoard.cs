using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab4v2.Models
{
    public class NewsBoard
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Registration Number")]
        [Required(ErrorMessage = "Registration Number is required.")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "Fee must be a valid currency.")]
        [Column(TypeName = "money")]
        public decimal Fee { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }

    }
}

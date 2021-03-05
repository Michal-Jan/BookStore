using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_UI.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Title")]
        public string Title { get; set; }
        [DisplayName("Year published")]
        public int? Year { get; set; }
        [Required]
        [DisplayName("ISBN")]
        public string Isbn { get; set; }
        [Required]
        [DisplayName("Summary")]
        public string Summary { get; set; }
        [Required]
        [DisplayName("Cover image")]
        public string Image { get; set; }
        [Required]
        [DisplayName("Price")]
        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }
        [DisplayName("Author")]
        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie_3.Models
{
    public class Movies
    {
        public int id { get; set; }

        [StringLength(60, MinimumLength =2)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-z][A-Za-z]*$")]
        [Required]
        [StringLength(30)]
        public string Genre { get; set; }

        [Range (0,100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-z][A-Za-z]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }
}

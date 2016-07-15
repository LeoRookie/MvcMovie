using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models {
    public class Movie {
        private int id;
        private string title;
        private DateTime releaseDate;
        private string genre;
        private decimal price;

        public int Id {get {return id;}
            set {id = value;}
        }

        [Display(Name = "Movie Title")]
        [StringLength(60, MinimumLength = 3)]
        public string Title{
            get {return title;}
            set {title = value;}
        }


        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        
        public DateTime ReleaseDate {
            get {return releaseDate;}
            set { releaseDate = value;}
        }

        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Required]
        [StringLength(30)]
        public string Genre {
            get {
                return genre;
            }
            set {genre = value;}
        }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{0:C}", ApplyFormatInEditMode = true)]
        public decimal Price {
            get {
                if (price > 0) {
                    return price;
                }
                else {
                    return 0;
                }
            }
            set {
                if (value > 0) {
                    price = value;
                }
                else {
                    price = 0;
                }
            }
        }


        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(5)]
        public string Rating { get; set; }
    }

    public class MovieDBContext : DbContext {
        public DbSet<Movie> Movies { get; set; }
    }
}
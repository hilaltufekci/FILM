using System.ComponentModel.DataAnnotations;

namespace FilmNetCoreUygulaması.Models
{
    public class Film
    {
        [Key]
        public int FilmNo { get; set; }
        [Required]
        [StringLength(50)]
        public string FilmAdi { get; set; }

        [Required]
        [StringLength(10)]
        public string FilmTürü { get; set; }

        public int ımbd { get; set; }
        public string VizyonTarihi { get; set; }

    }
}

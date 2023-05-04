using System.ComponentModel.DataAnnotations;

namespace FilmNetCoreUygulaması.Models
{
    public class Seyirci
    {
        [Key]
        public int SeyirciNo { get; set; }

        [Required]
        [StringLength(30)]
        public string SeyirciAdi { get; set; }
        [Required]
        [StringLength(20)]
        public string SeyirciSoyadi { get; set; }

        [Required]
        [StringLength(6)]
        public string Cinsiyet { get; set; }

        [Required]
        [Range(12, 75, ErrorMessage = "Bu film için yaşınız uygun değildir.")]
        public int Yas { get; set; }
    }

}

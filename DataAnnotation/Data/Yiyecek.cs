using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation.Data
{
    [Table("Yiyecekler")]
    public class Yiyecek
    {
        [Key]
        public int Id { get; set; }

        
        [Required,MaxLength(100)]
        public string Ad { get; set; }

        public DateTime UretimTarihi { get; set; }

        public DateTime? SonKullanmaTarihi { get; set; }

        public decimal? Kalori { get; set; }

        public virtual ICollection<Hayvan> Hayvanlar { get; set; }
    }
}

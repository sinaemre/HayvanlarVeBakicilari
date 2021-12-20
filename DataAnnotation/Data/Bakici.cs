using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation.Data
{
    [Table("Bakicilar")]
    public class Bakici
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Ad { get; set; }
       
        [Required,MaxLength(100)]
        public string SoyAd { get; set; }

        public ICollection<Hayvan> Hayvanlar { get; set; }

    }
}

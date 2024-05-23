using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class WorldToWorld
    {
        public int Id { get; set; }

        [Display(Name = "Savaş Tarihi")]
        public int warDate { get; set; }

        [Display(Name = "Saldıran Ülke")]
        public string attackCountry { get; set; }

        [Display(Name = "Savunan Ülke")]
        public string defendCountry { get; set; }

        [Display(Name = "Saldırı Ağırlığı")]
        public string attackType { get; set; }
    }
}

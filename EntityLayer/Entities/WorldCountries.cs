using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class WorldCountries
    {
        public int Id { get; set; }

        [Display(Name = "Ülke Adı")]
        public string countryName { get; set; }

        [Display(Name = "Ülke Toplam Nüfuz")]
        public string population { get; set; }

        [Display(Name = "Ülke Kuruluş Tarihi")]
        public string countryDate { get; set; }

        [Display(Name = "Ülke Cumhurbaşkanı")]
        public string countryLeader { get; set; }
    }
}

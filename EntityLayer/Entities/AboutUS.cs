using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class AboutUS
    {
        public int Id { get; set; }

        [Display(Name = "Hakkımızda")]
        public int aboutUs { get; set; }
    }
}

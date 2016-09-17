using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleEF.Models
{
    public class NegaraMetadata
    {
        public int NegaraId { get; set; }

        [Required(ErrorMessage = "Nama harus diisi")]
        [Display(Name = "Nama Negara")]
        [StringLength(50)]
        public string NamaNegara { get; set; }
    }

    public class KotaMetadata
    {
        public int KotaId { get; set; }
        public int NegaraId { get; set; }

        [Required]
        public string NamaKota { get; set; }
    }
}
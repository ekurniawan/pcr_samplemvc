using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleEF.Models
{
    [MetadataType(typeof(NegaraMetadata))]
    public partial class Negara
    {
    }

    [MetadataType(typeof(KotaMetadata))]
    public partial class Kota
    {
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SessionLanguage.Models
{
    public class SessionLanguageInfo
    {

        [Key]
        public int SessionvarsId { get; set; }
        public string langsesstr { get; set; }


    }
}
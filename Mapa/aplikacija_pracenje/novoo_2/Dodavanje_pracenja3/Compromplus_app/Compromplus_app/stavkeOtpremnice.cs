//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compromplus_app
{
    using System;
    using System.Collections.Generic;
    
    public partial class stavkeOtpremnice
    {
        public int idArtikl { get; set; }
        public int idOtpremnica { get; set; }
        public Nullable<int> kolicina { get; set; }
    
        public virtual Artikl Artikl { get; set; }
        public virtual Otpremnica Otpremnica { get; set; }
    }
}
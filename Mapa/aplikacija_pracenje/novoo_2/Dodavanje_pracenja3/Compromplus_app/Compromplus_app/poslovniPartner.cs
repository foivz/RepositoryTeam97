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
    
    public partial class poslovniPartner
    {
        public poslovniPartner()
        {
            this.Narudzbenica = new HashSet<Narudzbenica>();
            this.Otpremnica = new HashSet<Otpremnica>();
        }
    
        public int IdPoslovniPartner { get; set; }
        public string naziv { get; set; }
        public string adresa { get; set; }
        public string email { get; set; }
    
        public virtual ICollection<Narudzbenica> Narudzbenica { get; set; }
        public virtual ICollection<Otpremnica> Otpremnica { get; set; }
    }
}

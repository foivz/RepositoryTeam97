//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aplikacija
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipKorisnika
    {
        public TipKorisnika()
        {
            this.Korisnik = new HashSet<Korisnik>();
        }
    
        public int IdTipKorisnika { get; set; }
        public string uloga { get; set; }
    
        public virtual ICollection<Korisnik> Korisnik { get; set; }
    }
}

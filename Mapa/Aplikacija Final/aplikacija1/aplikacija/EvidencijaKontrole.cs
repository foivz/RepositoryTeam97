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
    
    public partial class EvidencijaKontrole
    {
        public EvidencijaKontrole()
        {
            this.Artikli = new HashSet<Artikli>();
        }
    
        public int IdEvidencijaKontrole { get; set; }
        public string klasa { get; set; }
        public string opis { get; set; }
    
        public virtual ICollection<Artikli> Artikli { get; set; }
    }
}

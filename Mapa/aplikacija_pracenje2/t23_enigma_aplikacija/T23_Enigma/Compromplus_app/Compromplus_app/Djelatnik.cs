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
    
    public partial class Djelatnik
    {
        public Djelatnik()
        {
            this.PracenjeProizvodnje = new HashSet<PracenjeProizvodnje>();
        }
    
        public int IdDjelatnik { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string adresa { get; set; }
        public string strucnaSprema { get; set; }
        public int stroj { get; set; }
    
        public virtual ICollection<PracenjeProizvodnje> PracenjeProizvodnje { get; set; }
    }
}

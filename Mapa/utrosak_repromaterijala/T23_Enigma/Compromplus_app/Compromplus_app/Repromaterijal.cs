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
    
    public partial class Repromaterijal
    {
        public Repromaterijal()
        {
            this.Utrosak = new HashSet<Utrosak>();
        }
    
        public int IdRepromaterijal { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public Nullable<int> kolicina { get; set; }
        public Nullable<int> velicina { get; set; }
        public Nullable<int> barkod { get; set; }
        public string boja { get; set; }
    
        public virtual ICollection<Utrosak> Utrosak { get; set; }
    }
}

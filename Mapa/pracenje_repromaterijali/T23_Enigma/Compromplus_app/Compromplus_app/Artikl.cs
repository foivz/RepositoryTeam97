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
    
    public partial class Artikl
    {
        public Artikl()
        {
            this.StavkeDokumenta = new HashSet<StavkeDokumenta>();
            this.Utrosak = new HashSet<Utrosak>();
            this.PracenjeProizvodnje = new HashSet<PracenjeProizvodnje>();
        }
    
        public int IdArtikl { get; set; }
        public string naziv { get; set; }
        public string opis { get; set; }
        public string boja { get; set; }
        public Nullable<int> kolicina { get; set; }
        public string klasa { get; set; }
    
        public virtual ICollection<StavkeDokumenta> StavkeDokumenta { get; set; }
        public virtual ICollection<Utrosak> Utrosak { get; set; }
        public virtual ICollection<PracenjeProizvodnje> PracenjeProizvodnje { get; set; }

        internal IList<Artikl> ToList<T1>()
        {
            throw new NotImplementedException();
        }
    }
}

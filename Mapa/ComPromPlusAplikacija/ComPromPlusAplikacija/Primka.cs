//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComPromPlusAplikacija
{
    using System;
    using System.Collections.Generic;
    
    public partial class Primka
    {
        public Primka()
        {
            this.stavkePrimke = new HashSet<stavkePrimke>();
        }
    
        public int Id { get; set; }
        public string naziv { get; set; }
        public Nullable<System.DateTime> datumZaprimanja { get; set; }
        public string opis { get; set; }
        public int knjizenjeDok { get; set; }
    
        public virtual knjizenjeDokumenta knjizenjeDokumenta { get; set; }
        public virtual ICollection<stavkePrimke> stavkePrimke { get; set; }
    }
}

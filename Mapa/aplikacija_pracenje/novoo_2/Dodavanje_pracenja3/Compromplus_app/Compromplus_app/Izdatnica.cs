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
    
    public partial class Izdatnica
    {
        public Izdatnica()
        {
            this.stavkeIzdatnice = new HashSet<stavkeIzdatnice>();
        }
    
        public int IdIzdatnica { get; set; }
        public string naziv { get; set; }
        public string boja { get; set; }
        public Nullable<System.DateTime> datum { get; set; }
        public int knjizenjeDok { get; set; }
    
        public virtual KnjizenjeDokumenta KnjizenjeDokumenta { get; set; }
        public virtual ICollection<stavkeIzdatnice> stavkeIzdatnice { get; set; }

        public string opis { get; set; }
    }
}

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
    
    public partial class Dokument
    {
        public Dokument()
        {
            this.StavkeDokumenta = new HashSet<StavkeDokumenta>();
        }
    
        public int IdDokument { get; set; }
        public Nullable<System.DateTime> datum { get; set; }
        public string opis { get; set; }
        public Nullable<int> tipDokumenta { get; set; }
        public Nullable<int> knjizenjeDokumenta { get; set; }
    
        public virtual KnjizenjeDokumenta KnjizenjeDokumenta1 { get; set; }
        public virtual TipDokumenta TipDokumenta1 { get; set; }
        public virtual ICollection<StavkeDokumenta> StavkeDokumenta { get; set; }
    }
}

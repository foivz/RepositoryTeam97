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
    
    public partial class KnjizenjeDokumenta
    {
        public KnjizenjeDokumenta()
        {
            this.Dokument = new HashSet<Dokument>();
        }
    
        public int IdKnjizenjeDokumenta { get; set; }
        public string status { get; set; }
    
        public virtual ICollection<Dokument> Dokument { get; set; }
    }
}

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
    
    public partial class Stroj
    {
        public int IdStroj { get; set; }
        public string naziv { get; set; }
        public Nullable<int> djelatnik { get; set; }
    
        public virtual Djelatnik Djelatnik1 { get; set; }
    }
}

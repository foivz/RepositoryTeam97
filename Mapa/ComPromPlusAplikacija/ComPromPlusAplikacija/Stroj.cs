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
    
    public partial class Stroj
    {
        public Stroj()
        {
            this.Djelatnik = new HashSet<Djelatnik>();
            this.pracenjeProizvodnje = new HashSet<pracenjeProizvodnje>();
        }
    
        public int Id { get; set; }
        public string naziv { get; set; }
    
        public virtual ICollection<Djelatnik> Djelatnik { get; set; }
        public virtual ICollection<pracenjeProizvodnje> pracenjeProizvodnje { get; set; }
    }
}
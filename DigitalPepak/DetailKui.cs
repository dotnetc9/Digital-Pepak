//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalPepak
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailKui
    {
        public int DetailKuisId { get; set; }
        public Nullable<int> KuisId { get; set; }
        public Nullable<int> SoalId { get; set; }
    
        public virtual Kui Kui { get; set; }
        public virtual Soal Soal { get; set; }
    }
}

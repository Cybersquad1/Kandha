//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NibsMVC.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class PriceGroupMapping
    {
        public decimal UID { get; set; }
        public decimal AccountM_UID { get; set; }
        public decimal HallType_UID { get; set; }
        public bool IsActive { get; set; }
        public bool IsIndividualHallPrice { get; set; }
        public decimal PriceGroup_UID { get; set; }
    
        public virtual AccountM AccountM { get; set; }
        public virtual MasterM MasterM { get; set; }
    }
}
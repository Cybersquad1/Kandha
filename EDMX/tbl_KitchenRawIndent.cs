//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NibsMVC.EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_KitchenRawIndent
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ItemId { get; set; }
        public int RawMaterialId { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }
        public Nullable<int> Portion { get; set; }
    
        public virtual tbl_RawMaterials tbl_RawMaterials { get; set; }
        public virtual tblCategory tblCategory { get; set; }
        public virtual tblItem tblItem { get; set; }
    }
}

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
    
    public partial class CouponCodeM_PromoMapping
    {
        public decimal UID { get; set; }
        public decimal CouponCodeM_UID { get; set; }
        public decimal Promo_Header_UID { get; set; }
    
        public virtual CouponCodeM CouponCodeM { get; set; }
    }
}

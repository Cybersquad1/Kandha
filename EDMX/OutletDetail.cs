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
    
    public partial class OutletDetail
    {
        public System.Guid UID { get; set; }
        public decimal OutletUID { get; set; }
        public System.Guid MerchantUID { get; set; }
        public Nullable<System.Guid> OutletUGUID { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual MerchantDetail MerchantDetail { get; set; }
    }
}

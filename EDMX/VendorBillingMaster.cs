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
    
    public partial class VendorBillingMaster
    {
        public VendorBillingMaster()
        {
            this.VendorBillingItems = new HashSet<VendorBillingItem>();
        }
    
        public int OrderId { get; set; }
        public int OutletId { get; set; }
        public int VendorId { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public Nullable<System.DateTime> ChequeDate { get; set; }
        public string ChequeNo { get; set; }
        public Nullable<decimal> DepositAmount { get; set; }
        public Nullable<decimal> remainingAmount { get; set; }
        public decimal VatAmount { get; set; }
        public decimal ServiceChargeAmount { get; set; }
        public decimal ServicTaxAmount { get; set; }
        public decimal NetAmount { get; set; }
        public System.DateTime BillDate { get; set; }
    
        public virtual tblOutlet tblOutlet { get; set; }
        public virtual ICollection<VendorBillingItem> VendorBillingItems { get; set; }
        public virtual OutletVendor OutletVendor { get; set; }
    }
}

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
    
    public partial class DailyStockClosing
    {
        public decimal UID { get; set; }
        public decimal Branch_UID { get; set; }
        public decimal ProductID { get; set; }
        public decimal Opening { get; set; }
        public decimal Purchase { get; set; }
        public decimal Excess { get; set; }
        public decimal Usage { get; set; }
        public decimal Wastage { get; set; }
        public decimal PurReturn { get; set; }
        public decimal Shortage { get; set; }
        public decimal Other { get; set; }
        public decimal Closing { get; set; }
        public System.DateTime ClosingDate { get; set; }
        public decimal Physical { get; set; }
        public decimal SqlLite_UID { get; set; }
        public Nullable<decimal> Pur_Price { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> SalesValue { get; set; }
        public string BranchName { get; set; }
        public string Itemname { get; set; }
        public string Category { get; set; }
        public Nullable<decimal> Category_UID { get; set; }
        public Nullable<System.Guid> DeviceGUID { get; set; }
    }
}

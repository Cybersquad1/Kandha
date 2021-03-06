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
    
    public partial class AccountM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccountM()
        {
            this.AccountMGroups = new HashSet<AccountMGroup>();
            this.AccountMItems = new HashSet<AccountMItem>();
            this.AccountMPartners = new HashSet<AccountMPartner>();
            this.CommodityM_AccountM_Mapping = new HashSet<CommodityM_AccountM_Mapping>();
            this.CommodityM_Hall_Mapping = new HashSet<CommodityM_Hall_Mapping>();
            this.CommodityM_ServiceTaxMaster_Mapping = new HashSet<CommodityM_ServiceTaxMaster_Mapping>();
            this.EXP_AccountM = new HashSet<EXP_AccountM>();
            this.KOTTrans = new HashSet<KOTTran>();
            this.KOTTrans1 = new HashSet<KOTTran>();
            this.PriceGroupMappings = new HashSet<PriceGroupMapping>();
            this.SAPItemSubGroupDineGroupMappings = new HashSet<SAPItemSubGroupDineGroupMapping>();
            this.SAPItemSubGroupDineGroupMappings1 = new HashSet<SAPItemSubGroupDineGroupMapping>();
        }
    
        public decimal UID { get; set; }
        public string AccountCode { get; set; }
        public string Description { get; set; }
        public int AccountType { get; set; }
        public bool IsAccount { get; set; }
        public string ShortDescription { get; set; }
        public string PrintDescription { get; set; }
        public bool IsGroup { get; set; }
        public decimal Percentage { get; set; }
        public bool IsHall { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountMGroup> AccountMGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountMItem> AccountMItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountMPartner> AccountMPartners { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommodityM_AccountM_Mapping> CommodityM_AccountM_Mapping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommodityM_Hall_Mapping> CommodityM_Hall_Mapping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommodityM_ServiceTaxMaster_Mapping> CommodityM_ServiceTaxMaster_Mapping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXP_AccountM> EXP_AccountM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KOTTran> KOTTrans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KOTTran> KOTTrans1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceGroupMapping> PriceGroupMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAPItemSubGroupDineGroupMapping> SAPItemSubGroupDineGroupMappings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAPItemSubGroupDineGroupMapping> SAPItemSubGroupDineGroupMappings1 { get; set; }
    }
}

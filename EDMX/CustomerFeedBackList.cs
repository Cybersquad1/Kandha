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
    
    public partial class CustomerFeedBackList
    {
        public decimal UID { get; set; }
        public decimal CustomerFeedBack_UID { get; set; }
        public decimal FeedBack_UID { get; set; }
        public string Answer { get; set; }
    
        public virtual CustomerFeedBack CustomerFeedBack { get; set; }
        public virtual FeedBackMaster FeedBackMaster { get; set; }
    }
}

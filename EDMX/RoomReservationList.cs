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
    
    public partial class RoomReservationList
    {
        public decimal UID { get; set; }
        public decimal RoomReservationTrans_UID { get; set; }
        public decimal RoomsM_UID { get; set; }
        public Nullable<decimal> Tariff_UID { get; set; }
    
        public virtual RoomReservationTran RoomReservationTran { get; set; }
        public virtual RoomsM RoomsM { get; set; }
    }
}

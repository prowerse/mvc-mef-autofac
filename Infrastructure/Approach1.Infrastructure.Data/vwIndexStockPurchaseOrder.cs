//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Approach1.Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwIndexStockPurchaseOrder
    {
        public int StockPurchaseOrderID { get; set; }
        public Nullable<int> PONumber { get; set; }
        public Nullable<int> ItemCount { get; set; }
        public Nullable<byte> Closed { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string DateCreatedString { get; set; }
        public string SupplierName { get; set; }
        public string BrandTitle { get; set; }
        public Nullable<int> Quantity { get; set; }
    }
}

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
    
    public partial class StockItembk
    {
        public int StockItembkId { get; set; }
        public string SerialNumber { get; set; }
        public string Pin { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> StockPurchaseOrderId { get; set; }
        public Nullable<int> StockInvoiceId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> ReturnStatus { get; set; }
        public Nullable<int> BrandId { get; set; }
        public string SIM { get; set; }
        public Nullable<int> Received { get; set; }
        public Nullable<int> StockStatusId { get; set; }
        public Nullable<int> OrderItemId { get; set; }
    }
}
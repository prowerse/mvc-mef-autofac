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
    
    public partial class StockItemOrderHistory
    {
        public int StockItemOrderHistoryId { get; set; }
        public System.DateTime OccuredOn { get; set; }
        public int StockItemId { get; set; }
        public int OrderItemDataId { get; set; }
        public string Comment { get; set; }
        public int OrderItemId { get; set; }
    
        public virtual OrderItem OrderItem { get; set; }
        public virtual StockItem StockItem { get; set; }
    }
}

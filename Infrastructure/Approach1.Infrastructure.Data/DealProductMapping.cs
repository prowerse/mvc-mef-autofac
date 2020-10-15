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
    
    public partial class DealProductMapping
    {
        public int DealProductMappingId { get; set; }
        public Nullable<int> DealId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> CreatedUserId { get; set; }
        public Nullable<System.DateTime> DbInsertDate { get; set; }
        public Nullable<int> ModifiedUserId { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Deal Deal { get; set; }
        public virtual Product Product { get; set; }
    }
}
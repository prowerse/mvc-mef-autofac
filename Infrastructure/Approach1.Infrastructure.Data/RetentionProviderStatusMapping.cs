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
    
    public partial class RetentionProviderStatusMapping
    {
        public int RetentionProviderStatusMappingId { get; set; }
        public int StatusId { get; set; }
        public Nullable<int> ProviderId { get; set; }
        public int SuccessOrderStatusDetailId { get; set; }
        public Nullable<int> InCompleteOrderStatusDetailId { get; set; }
        public int FailedOrderStatusDetailId { get; set; }
        public Nullable<int> OperationsProviderSpecificQueueId { get; set; }
        public string ButtonText { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPublished { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    
        public virtual OperationsProviderSpecificQueue OperationsProviderSpecificQueue { get; set; }
        public virtual OrderStatusDetail OrderStatusDetail { get; set; }
        public virtual OrderStatusDetail OrderStatusDetail1 { get; set; }
        public virtual OrderStatusDetail OrderStatusDetail2 { get; set; }
        public virtual OrderStatusDetail OrderStatusDetail3 { get; set; }
    }
}

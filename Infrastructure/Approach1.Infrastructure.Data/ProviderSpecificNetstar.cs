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
    
    public partial class ProviderSpecificNetstar
    {
        public int ProviderSpecificNetstarId { get; set; }
        public int OrderItemId { get; set; }
        public int InstallerId { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<System.DateTime> FitmentDate { get; set; }
        public bool FitmentActivated { get; set; }
        public string FitmentType { get; set; }
        public Nullable<int> CreatedByUserId_ { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
    
        public virtual Installer Installer { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}

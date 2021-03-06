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
    
    public partial class TelkomSpecificProvider
    {
        public int TelkomSpecificProviderId { get; set; }
        public int OrderItemId { get; set; }
        public int DealId { get; set; }
        public int RelationshipId { get; set; }
        public string RelativesName { get; set; }
        public string RelativesContactNo { get; set; }
        public int MaritalStatusId { get; set; }
        public string MaidenName { get; set; }
        public Nullable<int> NoOfDependants { get; set; }
        public int EducationId { get; set; }
        public int ResIdenceTypeId { get; set; }
        public System.DateTime DateOfAddress { get; set; }
        public string PreviousAddress { get; set; }
        public int ProfessionId { get; set; }
        public int CurrentPeriodEmployedId { get; set; }
        public int IndustryId { get; set; }
        public int ClientTypeId { get; set; }
    
        public virtual ClientType ClientType { get; set; }
        public virtual CurrentPeriodEmployed CurrentPeriodEmployed { get; set; }
        public virtual Education Education { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual Profession Profession { get; set; }
        public virtual Relationship Relationship { get; set; }
        public virtual CustomerMaritalStatu CustomerMaritalStatu { get; set; }
        public virtual Deal Deal { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}

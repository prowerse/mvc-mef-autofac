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
    
    public partial class CustomerAccount
    {
        public int CustomerAccountId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string AccountNo { get; set; }
        public Nullable<int> BranchCodeId { get; set; }
        public Nullable<int> AccountTypeId { get; set; }
        public Nullable<System.DateTime> DateOpened { get; set; }
        public Nullable<int> PaymentMethodId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Initials { get; set; }
        public Nullable<int> DebitDay { get; set; }
        public Nullable<int> CreatedByUserId { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> UpdatedByUserId { get; set; }
        public Nullable<System.DateTime> UpdatedOnDate { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual AccountType AccountType { get; set; }
        public virtual BankBranch BankBranch { get; set; }
        public virtual PayMethod PayMethod { get; set; }
        public virtual Customer Customer { get; set; }
    }
}

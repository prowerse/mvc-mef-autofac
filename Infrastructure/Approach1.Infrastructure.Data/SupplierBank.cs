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
    
    public partial class SupplierBank
    {
        public int SupplierBankId { get; set; }
        public int SupplierId { get; set; }
        public int BranchCodeId { get; set; }
        public string SupplierBankName { get; set; }
    
        public virtual BankBranch BankBranch { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
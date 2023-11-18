//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodDelivery_Backend.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_transaction_info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_transaction_info()
        {
            this.tbl_issue_info = new HashSet<tbl_issue_info>();
            this.tbl_order_info = new HashSet<tbl_order_info>();
        }
    
        public decimal trans_id { get; set; }
        public Nullable<decimal> cust_id { get; set; }
        public Nullable<decimal> supplier_id { get; set; }
        public Nullable<decimal> order_id { get; set; }
        public Nullable<decimal> agent_id { get; set; }
        public Nullable<decimal> amount { get; set; }
        public string trans_mode { get; set; }
        public Nullable<System.DateTime> trans_datetime { get; set; }
        public string trans_status { get; set; }
        public string trans_remarks { get; set; }
    
        public virtual tbl_agent_info tbl_agent_info { get; set; }
        public virtual tbl_cust_info tbl_cust_info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_issue_info> tbl_issue_info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_order_info> tbl_order_info { get; set; }
        public virtual tbl_supplier_info tbl_supplier_info { get; set; }
    }
}

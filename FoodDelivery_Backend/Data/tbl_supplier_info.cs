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
    
    public partial class tbl_supplier_info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_supplier_info()
        {
            this.tbl_cart_info = new HashSet<tbl_cart_info>();
            this.tbl_order_breakup = new HashSet<tbl_order_breakup>();
            this.tbl_supplier_menu = new HashSet<tbl_supplier_menu>();
            this.tbl_transaction_info = new HashSet<tbl_transaction_info>();
        }
    
        public decimal supplier_id { get; set; }
        public string supplier_name { get; set; }
        public string supplier_address { get; set; }
        public Nullable<decimal> supplier_gst_num { get; set; }
        public string reg_date { get; set; }
        public Nullable<decimal> pincode { get; set; }
        public string supplier_type { get; set; }
        public string supplier_status { get; set; }
        public string longtitude { get; set; }
        public string latitude { get; set; }
        public string serv_pin_list { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_cart_info> tbl_cart_info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_order_breakup> tbl_order_breakup { get; set; }
        public virtual tbl_supplier_type tbl_supplier_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_supplier_menu> tbl_supplier_menu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_transaction_info> tbl_transaction_info { get; set; }
    }
}

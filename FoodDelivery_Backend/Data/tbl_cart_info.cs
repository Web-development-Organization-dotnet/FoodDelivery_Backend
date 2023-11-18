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
    
    public partial class tbl_cart_info
    {
        public decimal slno { get; set; }
        public Nullable<decimal> food_id { get; set; }
        public string food_name { get; set; }
        public string status { get; set; }
        public Nullable<decimal> supplier_id { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> cust_id { get; set; }
        public Nullable<decimal> cust_address_id { get; set; }
        public Nullable<System.DateTime> cart_regist_date { get; set; }
        public Nullable<System.DateTime> process_date { get; set; }
    
        public virtual tbl_cust_addr tbl_cust_addr { get; set; }
        public virtual tbl_cust_info tbl_cust_info { get; set; }
        public virtual tbl_food_info tbl_food_info { get; set; }
        public virtual tbl_supplier_info tbl_supplier_info { get; set; }
    }
}

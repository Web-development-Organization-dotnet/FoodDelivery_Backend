﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Food_Delivery_DbEntities : DbContext
    {
        public Food_Delivery_DbEntities()
            : base("name=Food_Delivery_DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_admin_info> tbl_admin_info { get; set; }
        public virtual DbSet<tbl_agent_category> tbl_agent_category { get; set; }
        public virtual DbSet<tbl_agent_info> tbl_agent_info { get; set; }
        public virtual DbSet<tbl_cart_info> tbl_cart_info { get; set; }
        public virtual DbSet<tbl_cust_addr> tbl_cust_addr { get; set; }
        public virtual DbSet<tbl_cust_info> tbl_cust_info { get; set; }
        public virtual DbSet<tbl_cust_payment_mode> tbl_cust_payment_mode { get; set; }
        public virtual DbSet<tbl_cust_type> tbl_cust_type { get; set; }
        public virtual DbSet<tbl_cust_wallet> tbl_cust_wallet { get; set; }
        public virtual DbSet<tbl_delivery_info> tbl_delivery_info { get; set; }
        public virtual DbSet<tbl_food_info> tbl_food_info { get; set; }
        public virtual DbSet<tbl_food_type> tbl_food_type { get; set; }
        public virtual DbSet<tbl_issue_info> tbl_issue_info { get; set; }
        public virtual DbSet<tbl_order_breakup> tbl_order_breakup { get; set; }
        public virtual DbSet<tbl_order_info> tbl_order_info { get; set; }
        public virtual DbSet<tbl_supplier_info> tbl_supplier_info { get; set; }
        public virtual DbSet<tbl_supplier_menu> tbl_supplier_menu { get; set; }
        public virtual DbSet<tbl_supplier_type> tbl_supplier_type { get; set; }
        public virtual DbSet<tbl_transaction_info> tbl_transaction_info { get; set; }
    }
}

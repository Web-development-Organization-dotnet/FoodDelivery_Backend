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
    
    public partial class tbl_food_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_food_type()
        {
            this.tbl_food_info = new HashSet<tbl_food_info>();
        }
    
        public string food_type_cd { get; set; }
        public string food_type { get; set; }
        public string type_desc { get; set; }
        public string food_category { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_food_info> tbl_food_info { get; set; }
    }
}

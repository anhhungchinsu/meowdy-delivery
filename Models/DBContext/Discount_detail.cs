//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.DBContext
{
	using Newtonsoft.Json;
	using System;
    using System.Collections.Generic;
    
    public partial class Discount_detail
    {
        public short discount_detail_user_id { get; set; }
        public short discount_detail_discount_id { get; set; }
        public Nullable<System.DateTime> discount_detail_start_time { get; set; }
        public Nullable<System.DateTime> discount_detail_end_time { get; set; }
        [JsonIgnore]
        public virtual Discount Discount { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; }
    }
}

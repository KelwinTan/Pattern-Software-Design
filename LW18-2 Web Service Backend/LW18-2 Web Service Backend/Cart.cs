//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LW18_2_Web_Service_Backend
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public int UserID { get; set; }
        public int ShoeID { get; set; }
        public int Quantity { get; set; }
    
        public virtual Shoes Shoes { get; set; }
        public virtual User User { get; set; }
    }
}

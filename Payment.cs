//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Private_Hospital
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int Payment_ID { get; set; }
        public decimal Sum { get; set; }
        public System.DateTime Date { get; set; }
        public int Pacient_ID { get; set; }
        public string Product_name { get; set; }
    
        public virtual Pacient Pacient { get; set; }
    }
}
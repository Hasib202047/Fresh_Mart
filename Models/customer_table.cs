//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace freshMart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class customer_table
    {
        
        public int customer_id { get; set; }
        [DisplayName(" Customer Username")]
        [Required(ErrorMessage = "Customer username is a required field")]
        public string customer_username { get; set; }
        [EmailAddress]
        [DisplayName("Customer Email")]
        [Required(ErrorMessage = "Customer email is a required field")]
        public string customer_email { get; set; }
        [DisplayName("Customer Password")]
        [Required(ErrorMessage = "Customer password is a required field")]
        [DataType(DataType.Password)]
        public string customer_password { get; set; }
        
        [MinLength(11,ErrorMessage ="Mobile no should be 11 digit")]
        [DisplayName("Customer Contact Number")]
        [Required(ErrorMessage = "Customer contact number is a required field")]
        public string customer_contactNumber { get; set; }
    }
}

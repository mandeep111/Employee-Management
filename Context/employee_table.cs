//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee_Management.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class employee_table
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Required")]
        [EmailAddress]
        public string email { get; set; }
        public string address { get; set; }
        public string description { get; set; }

        [Required(ErrorMessage ="Required")]
        [MinLength(10, ErrorMessage = "Number should be 10 characters")]
        public string phone { get; set; }
    }
}

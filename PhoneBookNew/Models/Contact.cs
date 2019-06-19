//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhoneBookNew.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Contact
    {
        //Get and set value for ID
        public int Id { get; set; }
        //Validation
        [Required(ErrorMessage = "This field is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "The{0} must between{1} chars.")]
        //Get and set value for Name
        public string Name { get; set; }
        //Validation
        [Required(ErrorMessage = "This field is required")]
        //Get and set value for Phone
        public string Phone { get; set; }
        //Valiadtion
        [EmailAddress(ErrorMessage = "Email address is not valid!")]
        //Get and set value for Email
        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd / MM / yyyy}")]
        //Get and set value for Date of Birth
        public Nullable<System.DateTime> Birthday { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CarsTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Factory { get; set; }
        public string Model { get; set; }

        [DisplayName("Warranty (years)")]
        public Nullable<int> Warranty { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/yyyy}",
           ApplyFormatInEditMode = true)]
        [DisplayName("Model Year")]
        public Nullable<System.DateTime> ModelYear { get; set; }
    }
}
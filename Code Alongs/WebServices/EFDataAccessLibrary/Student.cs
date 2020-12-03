namespace EFDataAccessLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Student
    {
        [DataMember]
        public int StudentId { get; set; }

        [DataMember]
        [StringLength(50)]
        public string FirstName { get; set; }

        [DataMember]
        [StringLength(50)]
        public string LastName { get; set; }

        [DataMember]
        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        [DataMember]
        [StringLength(50)]
        public string EmailAddr { get; set; }

        [DataMember]
        [StringLength(50)]
        public string Country { get; set; }
    }
}

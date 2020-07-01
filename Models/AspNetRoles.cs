﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectionPractice.Models
{
    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
        }

        [Key]
        [StringLength(128)]
        public string Id { get; set; }
        [Required]
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(256)]
        public string ConcurrencyStamp { get; set; }
        [Required]
        [StringLength(256)]
        public string NormalizedName { get; set; }

        [InverseProperty("Role")]
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
    }
}

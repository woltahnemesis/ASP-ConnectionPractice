﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectionPractice.Models
{
    public partial class AspNetUserRoles
    {
        [Key]
        [StringLength(128)]
        public string UserId { get; set; }
        [Key]
        [StringLength(128)]
        public string RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty(nameof(AspNetRoles.AspNetUserRoles))]
        public virtual AspNetRoles Role { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(AspNetUsers.AspNetUserRoles))]
        public virtual AspNetUsers User { get; set; }
    }
}

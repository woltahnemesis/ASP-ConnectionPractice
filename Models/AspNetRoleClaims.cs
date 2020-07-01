using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectionPractice.Models
{
    public partial class AspNetRoleClaims
    {
        [Key]
        [StringLength(128)]
        public string Id { get; set; }
        [StringLength(100)]
        public string ClaimType { get; set; }
        [StringLength(100)]
        public string ClaimValue { get; set; }
        [StringLength(50)]
        public string RoleId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MultitenantInNetCore.Models
{
    public class Tenant
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string HostName { get; set; }
    }
}

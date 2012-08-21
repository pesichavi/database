using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    [Table("T_DOMAIN_USERS_PROP")]
    public class DomainUsersProp
    {
        [Key]
      public int Id { get; set; }
      public DomainUsers DomainUserID { get; set; }
      [MaxLength(10)]
      public string  PropName { get; set; }
      public string PropVal { get; set; }	
      public bool PropActive { get; set; }	
    }
}

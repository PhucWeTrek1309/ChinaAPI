using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Database
{
    public class RoleDb
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? RoleDescription { get; set; }
        public int RoleStatus { get; set; }
        public DateTime CreateDate { set; get; } = DateTime.Now;
        public DateTime ModifiedDate { set; get; }
    }
}

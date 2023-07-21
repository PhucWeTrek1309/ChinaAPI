using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Database
{
    public class GroupDb
    {
        public int  GroupId { get; set; }
        public int ParentGroupId { get; set; }
        public int GroupLanguage { get; set; }
        public string? GroupApp { get; set; }
        public int GroupLevel { get; set; }
        public int GroupPosition { get; set; }
        public string? GroupName { get; set; }
        public string? GroupLink { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; } 
    }
}

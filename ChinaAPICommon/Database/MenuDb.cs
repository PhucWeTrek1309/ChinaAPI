using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Database
{
    public class MenuDb
    {
        public int MenuId { get; set; }

        public int ParentMenuId { get; set; }

        public int MenuLanguage { get; set; }

        public string? MenuApp { get; set;}

        public int MenuLevel { get; set;}

        public int MenuSort { get; set; }

        public int MenuStatus { get; set; }

        public int MenuTarget { get; set; }

        public string? MenuName { get; set; }

        public string? MenuLink { get; set; }
        public string? MenuImage { get; set; }
        public DateTime? CreateDate { get; set;} = DateTime.Now;
        public DateTime? ModifiedDate { get; set;}
    }
}

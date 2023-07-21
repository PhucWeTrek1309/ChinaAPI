using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinaAPICommon.Database
{
    public class ItemDb
    {
        public int  ItemId { get; set; }
        public int  ItemLanguage { get; set; }
        public string? ItemApp { get; set; }
        public int ItemCode { get; set; }
        public string? ItemTitle { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemContent { get; set; }
        public string? ItemImage { get; set; }
        public string? ItemAuthor { get; set; }
        public string? ItemMetaTitle { get; set; }
        public string? ItemMetaDescription { get; set; }
        public string? ItemMetaKeywords { get; set; }
        public string? ItemTag { get; set; }
        public string? ItemLink { get; set; }
        public decimal ItemPriceOld { get; set; }
        public decimal ItemPriceNew { get; set; }
        public int ItemTotalView { get; set; }
        public int  ItemSortOrder { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; } 
    }
}

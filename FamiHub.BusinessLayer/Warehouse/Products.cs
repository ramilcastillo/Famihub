using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiHub.BusinessLayer.Warehouse
{
    public static class Products
    {
        public class ProductInfo
        {
            public string Description { get; set; }
            public long ArticleNumber { get; set; }
            public decimal SalePrice { get; set; }
        }

        public static ProductInfo GetProductInfo(string barcode)
        {
            BECO_Pro_FAM_CCLink.Articles articles = new BECO_Pro_FAM_CCLink.Articles();
            var art = articles.GetArticleByBarcode(barcode);
            if (art.ArticleId != 0)
            {
                var result = new ProductInfo
                {
                    Description = art.ArticleDescription,
                    ArticleNumber = art.ArticleId,
                    SalePrice = art.SalePrice
                };
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}

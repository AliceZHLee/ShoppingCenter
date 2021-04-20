using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCenter.Models
{
    public class ProductPicture
    {
        public int ProductPictureId { get; set; }       
        public bool IsParentImage { get; set; }//0--not, 1--yes

        public Product Product { get; set; }//FK
        public int ProductId { get; set; }
        public string PictureLink { get; set; }
    }
}
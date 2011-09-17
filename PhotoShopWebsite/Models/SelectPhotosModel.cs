using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Photoshop.Model;

namespace PhotoShopWebsite.Models
{
    public class SelectPhotosModel
    {
        public List<Album> Albums { get; set; }
        public Order Order { get; set; }
    }
}
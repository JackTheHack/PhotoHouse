using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Photoshop.Model
{
    public class Photo
    {
        public bool Checked { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Src { get; set; }
        public string BigSrc { get; set; }
    }
}

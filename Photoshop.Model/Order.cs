using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Photoshop.Model.Enums;
using Norm;
using System.ComponentModel.DataAnnotations;

namespace Photoshop.Model
{
    public class Order
    {
        [MongoIdentifier]
        public ObjectId Id { get; set; }
        [Required]
        public PhotoSize Size { get; set; }
        [Required]
        public PaperFormat PaperType { get; set; }
        public int CopyCount { get; set; }
        public OrderStatus Status { get; set; }
        
        //Image ids in temporary storage
        [Required]
        public List<Guid> Images { get; set; }

        [Required]
        public string ClientVkId { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Telephone { get; set; }

        public Order()
        {
            Id = ObjectId.NewObjectId();
        }
    }
}

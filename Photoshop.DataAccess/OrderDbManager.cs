using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Photoshop.Model;

namespace Photoshop.DataAccess
{
    public class OrderDbManager : IDisposable
    {
        MongoSession<Order> session = new MongoSession<Order>();

        public List<Order> GetList()
        {
            return session.Queryable.ToList();
        }

        public void Add(Order item)
        {
            session.Add<Order>(new Order(){
                Address = "aadgdg",
                ClientVkId = "1353",
                CopyCount = 1,
                Images = new List<Guid>(),
                PaperType = PaperFormat.Glance,
                Size = PhotoSize.Size100x240,
                Status = Model.Enums.OrderStatus.Cashed,
                Telephone = "dgdgh"
            });
        }

        public void Dispose()
        {
            if (session != null)
            {
                session.Dispose();
            }
        }
    }
}

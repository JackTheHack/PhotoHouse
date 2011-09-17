using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Photoshop.Model.Enums
{
    public enum OrderStatus
    {
        Created,
        Verified,
        Printing,
        LocatingClient,
        Delivering,
        Delivered,
        Cashed
    }
}

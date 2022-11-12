using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapDemo
{
    public interface IMapView : IView
    {
    }

    public class MapView : View, IMapView
    {

    }
}

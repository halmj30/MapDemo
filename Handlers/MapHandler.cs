using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapDemo.Handlers
{
    partial class MapHandler
    {
        public static IPropertyMapper<MapView, MapHandler> MapMapper = new PropertyMapper<MapView, MapHandler>(ViewMapper)
        { };

        public MapHandler() : base(MapMapper)
        { }
    }
}

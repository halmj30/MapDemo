using CoreLocation;
using MapDemo.Controls;
using MapKit;
using Microsoft.Maui.Handlers;
using IMap = MapDemo.Controls.IMap;

namespace MapDemo.Handlers
{
    public partial class MapHandler : ViewHandler<IMap, MKMapView>
    {
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        MKMapView? _mkMapView;
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        CLLocationManager? _locationManager;
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

        protected override MKMapView CreatePlatformView()
        {
            _mkMapView = new MKMapView();
            return _mkMapView;
        }

        protected override void ConnectHandler(MKMapView platformView)
        {
            base.ConnectHandler(platformView);
            _locationManager = new CLLocationManager();
        }

        protected override void DisconnectHandler(MKMapView platformView)
        {
            _mkMapView?.Dispose();

            base.DisconnectHandler(platformView);
        }

        public static void MapMapType(IMapHandler handler, IMap map)
        {
            /*
            switch (map.MapType)
            {
                case MapType.Street:
                    handler.PlatformView.MapType = MKMapType.Standard;
                    break;
                case MapType.Satellite:
                    handler.PlatformView.MapType = MKMapType.Satellite;
                    break;
                case MapType.Hybrid:
                    handler.PlatformView.MapType = MKMapType.Hybrid;
                    break;
            }
            */
            handler.PlatformView.MapType = MKMapType.Hybrid;
        }

        public static void MapIsShowingUser(IMapHandler handler, IMap map)
        {
#if !MACCATALYST
            if ( true /*map.IsShowingUser*/)
            {
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
                MapHandler? mapHandler = handler as MapHandler;
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
                mapHandler?._locationManager?.RequestWhenInUseAuthorization();
            }
#endif
            handler.PlatformView.ShowsUserLocation = true; //hardcode so that it always shows
            //handler.PlatformView.ShowsUserLocation = map.IsShowingUser;
        }

        public static void MapHasScrollEnabled(IMapHandler handler, IMap map)
        {
            handler.PlatformView.ScrollEnabled = true;
            //handler.PlatformView.ScrollEnabled = map.HasScrollEnabled;
        }

        public static void MapHasTrafficEnabled(IMapHandler handler, IMap map)
        {
            handler.PlatformView.ShowsTraffic = false; //hardcoded so it doesnt show
            //handler.PlatformView.ShowsTraffic = map.HasTrafficEnabled;
        }

        public static void MapHasZoomEnabled(IMapHandler handler, IMap map)
        {
            handler.PlatformView.ZoomEnabled = true;
            //handler.PlatformView.ZoomEnabled = map.HasZoomEnabled;
        }
    }
}

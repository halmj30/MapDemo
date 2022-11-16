#if IOS || MACCATALYST
using PlatformView = MapKit.MKMapView;
#elif ANDROID
using Android.Gms.Maps;
using PlatformView = Android.Gms.Maps.MapView;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.FrameworkElement;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0 && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif
using IMap = MapDemo.Controls.IMap;

namespace MapDemo.Handlers
{
    public interface IMapHandler : IViewHandler
    {
        new IMap VirtualView { get; }
        new PlatformView PlatformView { get; }
#if ANDROID
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        GoogleMap? Map { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
#endif
    }
}

package crc64743ff33c304fcddf;


public class MapHelper
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.maps.OnMapReadyCallback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onMapReady:(Lcom/google/android/gms/maps/GoogleMap;)V:GetOnMapReady_Lcom_google_android_gms_maps_GoogleMap_Handler:Android.Gms.Maps.IOnMapReadyCallbackInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"";
		mono.android.Runtime.register ("MapDemo.Handlers.MapHelper, MapDemo", MapHelper.class, __md_methods);
	}


	public MapHelper ()
	{
		super ();
		if (getClass () == MapHelper.class)
			mono.android.TypeManager.Activate ("MapDemo.Handlers.MapHelper, MapDemo", "", this, new java.lang.Object[] {  });
	}

	public MapHelper (android.os.Bundle p0, com.google.android.gms.maps.MapView p1)
	{
		super ();
		if (getClass () == MapHelper.class)
			mono.android.TypeManager.Activate ("MapDemo.Handlers.MapHelper, MapDemo", "Android.OS.Bundle, Mono.Android:Android.Gms.Maps.MapView, Xamarin.GooglePlayServices.Maps", this, new java.lang.Object[] { p0, p1 });
	}


	public void onMapReady (com.google.android.gms.maps.GoogleMap p0)
	{
		n_onMapReady (p0);
	}

	private native void n_onMapReady (com.google.android.gms.maps.GoogleMap p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

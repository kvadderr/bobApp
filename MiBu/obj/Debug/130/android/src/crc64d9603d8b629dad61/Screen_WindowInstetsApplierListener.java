package crc64d9603d8b629dad61;


public class Screen_WindowInstetsApplierListener
	extends crc64d9603d8b629dad61.Screen_WindowInstetsConsumerListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Zebble.Device.Screen+WindowInstetsApplierListener, Zebble", Screen_WindowInstetsApplierListener.class, __md_methods);
	}


	public Screen_WindowInstetsApplierListener ()
	{
		super ();
		if (getClass () == Screen_WindowInstetsApplierListener.class) {
			mono.android.TypeManager.Activate ("Zebble.Device.Screen+WindowInstetsApplierListener, Zebble", "", this, new java.lang.Object[] {  });
		}
	}

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

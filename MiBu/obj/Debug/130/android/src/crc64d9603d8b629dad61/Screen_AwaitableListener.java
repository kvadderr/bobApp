package crc64d9603d8b629dad61;


public abstract class Screen_AwaitableListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Zebble.Device.Screen+AwaitableListener, Zebble", Screen_AwaitableListener.class, __md_methods);
	}


	public Screen_AwaitableListener ()
	{
		super ();
		if (getClass () == Screen_AwaitableListener.class) {
			mono.android.TypeManager.Activate ("Zebble.Device.Screen+AwaitableListener, Zebble", "", this, new java.lang.Object[] {  });
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

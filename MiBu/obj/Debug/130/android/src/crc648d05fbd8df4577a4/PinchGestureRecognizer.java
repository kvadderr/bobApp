package crc648d05fbd8df4577a4;


public class PinchGestureRecognizer
	extends crc648d05fbd8df4577a4.BaseGestureRecognizer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.PinchGestureRecognizer, Zebble", PinchGestureRecognizer.class, __md_methods);
	}


	public PinchGestureRecognizer ()
	{
		super ();
		if (getClass () == PinchGestureRecognizer.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.PinchGestureRecognizer, Zebble", "", this, new java.lang.Object[] {  });
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

package crc648d05fbd8df4577a4;


public abstract class BaseGestureRecognizer
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.BaseGestureRecognizer, Zebble", BaseGestureRecognizer.class, __md_methods);
	}


	public BaseGestureRecognizer ()
	{
		super ();
		if (getClass () == BaseGestureRecognizer.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.BaseGestureRecognizer, Zebble", "", this, new java.lang.Object[] {  });
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

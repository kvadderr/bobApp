package crc648b2957ff8abc3b50;


public class ZebbleBorderLayersDrawable
	extends android.graphics.drawable.LayerDrawable
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Zebble.ZebbleBorderLayersDrawable, Zebble", ZebbleBorderLayersDrawable.class, __md_methods);
	}


	public ZebbleBorderLayersDrawable (android.graphics.drawable.Drawable[] p0)
	{
		super (p0);
		if (getClass () == ZebbleBorderLayersDrawable.class) {
			mono.android.TypeManager.Activate ("Zebble.ZebbleBorderLayersDrawable, Zebble", "Android.Graphics.Drawables.Drawable[], Mono.Android", this, new java.lang.Object[] { p0 });
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

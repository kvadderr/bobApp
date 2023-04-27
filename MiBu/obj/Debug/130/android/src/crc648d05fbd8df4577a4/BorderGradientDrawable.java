package crc648d05fbd8df4577a4;


public class BorderGradientDrawable
	extends android.graphics.drawable.GradientDrawable
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.BorderGradientDrawable, Zebble", BorderGradientDrawable.class, __md_methods);
	}


	public BorderGradientDrawable ()
	{
		super ();
		if (getClass () == BorderGradientDrawable.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.BorderGradientDrawable, Zebble", "", this, new java.lang.Object[] {  });
		}
	}


	public BorderGradientDrawable (android.graphics.drawable.GradientDrawable.Orientation p0, int[] p1)
	{
		super (p0, p1);
		if (getClass () == BorderGradientDrawable.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.BorderGradientDrawable, Zebble", "Android.Graphics.Drawables.GradientDrawable+Orientation, Mono.Android:System.Int32[], mscorlib", this, new java.lang.Object[] { p0, p1 });
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

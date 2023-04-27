package crc640a43cd1db88e9113;


public class AndroidRenderExtensions_ZebbleAccelerateDecelerateInterpolator
	extends android.view.animation.AccelerateDecelerateInterpolator
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getInterpolation:(F)F:GetGetInterpolation_FHandler\n" +
			"";
		mono.android.Runtime.register ("System.AndroidRenderExtensions+ZebbleAccelerateDecelerateInterpolator, Zebble", AndroidRenderExtensions_ZebbleAccelerateDecelerateInterpolator.class, __md_methods);
	}


	public AndroidRenderExtensions_ZebbleAccelerateDecelerateInterpolator ()
	{
		super ();
		if (getClass () == AndroidRenderExtensions_ZebbleAccelerateDecelerateInterpolator.class) {
			mono.android.TypeManager.Activate ("System.AndroidRenderExtensions+ZebbleAccelerateDecelerateInterpolator, Zebble", "", this, new java.lang.Object[] {  });
		}
	}


	public AndroidRenderExtensions_ZebbleAccelerateDecelerateInterpolator (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AndroidRenderExtensions_ZebbleAccelerateDecelerateInterpolator.class) {
			mono.android.TypeManager.Activate ("System.AndroidRenderExtensions+ZebbleAccelerateDecelerateInterpolator, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}

	public AndroidRenderExtensions_ZebbleAccelerateDecelerateInterpolator (int p0)
	{
		super ();
		if (getClass () == AndroidRenderExtensions_ZebbleAccelerateDecelerateInterpolator.class) {
			mono.android.TypeManager.Activate ("System.AndroidRenderExtensions+ZebbleAccelerateDecelerateInterpolator, Zebble", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}


	public float getInterpolation (float p0)
	{
		return n_getInterpolation (p0);
	}

	private native float n_getInterpolation (float p0);

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

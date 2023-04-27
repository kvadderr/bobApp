package crc640a43cd1db88e9113;


public class AndroidRenderExtensions_ZebbleBounceInterpolator
	extends android.view.animation.BounceInterpolator
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getInterpolation:(F)F:GetGetInterpolation_FHandler\n" +
			"";
		mono.android.Runtime.register ("System.AndroidRenderExtensions+ZebbleBounceInterpolator, Zebble", AndroidRenderExtensions_ZebbleBounceInterpolator.class, __md_methods);
	}


	public AndroidRenderExtensions_ZebbleBounceInterpolator ()
	{
		super ();
		if (getClass () == AndroidRenderExtensions_ZebbleBounceInterpolator.class) {
			mono.android.TypeManager.Activate ("System.AndroidRenderExtensions+ZebbleBounceInterpolator, Zebble", "", this, new java.lang.Object[] {  });
		}
	}


	public AndroidRenderExtensions_ZebbleBounceInterpolator (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AndroidRenderExtensions_ZebbleBounceInterpolator.class) {
			mono.android.TypeManager.Activate ("System.AndroidRenderExtensions+ZebbleBounceInterpolator, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}

	public AndroidRenderExtensions_ZebbleBounceInterpolator (double p0, double p1)
	{
		super ();
		if (getClass () == AndroidRenderExtensions_ZebbleBounceInterpolator.class) {
			mono.android.TypeManager.Activate ("System.AndroidRenderExtensions+ZebbleBounceInterpolator, Zebble", "System.Double, mscorlib:System.Double, mscorlib", this, new java.lang.Object[] { p0, p1 });
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

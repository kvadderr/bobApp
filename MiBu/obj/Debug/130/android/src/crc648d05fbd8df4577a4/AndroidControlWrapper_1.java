package crc648d05fbd8df4577a4;


public class AndroidControlWrapper_1
	extends android.widget.FrameLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_setPadding:(IIII)V:GetSetPadding_IIIIHandler\n" +
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.AndroidControlWrapper`1, Zebble", AndroidControlWrapper_1.class, __md_methods);
	}


	public AndroidControlWrapper_1 (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AndroidControlWrapper_1.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidControlWrapper`1, Zebble", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public AndroidControlWrapper_1 (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AndroidControlWrapper_1.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidControlWrapper`1, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public AndroidControlWrapper_1 (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == AndroidControlWrapper_1.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidControlWrapper`1, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public AndroidControlWrapper_1 (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == AndroidControlWrapper_1.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidControlWrapper`1, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public void setPadding (int p0, int p1, int p2, int p3)
	{
		n_setPadding (p0, p1, p2, p3);
	}

	private native void n_setPadding (int p0, int p1, int p2, int p3);

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

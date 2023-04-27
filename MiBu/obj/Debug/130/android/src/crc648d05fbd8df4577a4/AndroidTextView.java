package crc648d05fbd8df4577a4;


public class AndroidTextView
	extends android.widget.TextView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.AndroidTextView, Zebble", AndroidTextView.class, __md_methods);
	}


	public AndroidTextView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AndroidTextView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidTextView, Zebble", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public AndroidTextView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AndroidTextView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidTextView, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public AndroidTextView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == AndroidTextView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidTextView, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public AndroidTextView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == AndroidTextView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidTextView, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
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

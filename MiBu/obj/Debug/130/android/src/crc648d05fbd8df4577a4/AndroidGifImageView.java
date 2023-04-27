package crc648d05fbd8df4577a4;


public class AndroidGifImageView
	extends android.widget.ImageView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDetachedFromWindow:()V:GetOnDetachedFromWindowHandler\n" +
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.AndroidGifImageView, Zebble", AndroidGifImageView.class, __md_methods);
	}


	public AndroidGifImageView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AndroidGifImageView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidGifImageView, Zebble", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public AndroidGifImageView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AndroidGifImageView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidGifImageView, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public AndroidGifImageView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == AndroidGifImageView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidGifImageView, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public AndroidGifImageView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == AndroidGifImageView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidGifImageView, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public void onDetachedFromWindow ()
	{
		n_onDetachedFromWindow ();
	}

	private native void n_onDetachedFromWindow ();

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

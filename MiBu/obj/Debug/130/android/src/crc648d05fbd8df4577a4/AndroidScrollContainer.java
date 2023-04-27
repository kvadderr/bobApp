package crc648d05fbd8df4577a4;


public class AndroidScrollContainer
	extends crc648d05fbd8df4577a4.AndroidGestureView_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_addView:(Landroid/view/View;)V:GetAddView_Landroid_view_View_Handler\n" +
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.AndroidScrollContainer, Zebble", AndroidScrollContainer.class, __md_methods);
	}


	public AndroidScrollContainer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AndroidScrollContainer.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidScrollContainer, Zebble", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public AndroidScrollContainer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AndroidScrollContainer.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidScrollContainer, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public AndroidScrollContainer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == AndroidScrollContainer.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidScrollContainer, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public AndroidScrollContainer (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == AndroidScrollContainer.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidScrollContainer, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public void addView (android.view.View p0)
	{
		n_addView (p0);
	}

	private native void n_addView (android.view.View p0);

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

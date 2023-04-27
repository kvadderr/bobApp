package crc648d05fbd8df4577a4;


public class AndroidLinearContainer
	extends android.widget.LinearLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getLayoutParams:()Landroid/view/ViewGroup$LayoutParams;:GetGetLayoutParametersHandler\n" +
			"n_setLayoutParams:(Landroid/view/ViewGroup$LayoutParams;)V:GetSetLayoutParameters_Landroid_view_ViewGroup_LayoutParams_Handler\n" +
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.AndroidLinearContainer, Zebble", AndroidLinearContainer.class, __md_methods);
	}


	public AndroidLinearContainer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AndroidLinearContainer.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidLinearContainer, Zebble", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public AndroidLinearContainer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AndroidLinearContainer.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidLinearContainer, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public AndroidLinearContainer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == AndroidLinearContainer.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidLinearContainer, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public AndroidLinearContainer (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == AndroidLinearContainer.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidLinearContainer, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public android.view.ViewGroup.LayoutParams getLayoutParams ()
	{
		return n_getLayoutParams ();
	}

	private native android.view.ViewGroup.LayoutParams n_getLayoutParams ();


	public void setLayoutParams (android.view.ViewGroup.LayoutParams p0)
	{
		n_setLayoutParams (p0);
	}

	private native void n_setLayoutParams (android.view.ViewGroup.LayoutParams p0);

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

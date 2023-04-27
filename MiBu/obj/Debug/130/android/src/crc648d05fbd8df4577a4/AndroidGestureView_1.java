package crc648d05fbd8df4577a4;


public class AndroidGestureView_1
	extends android.widget.FrameLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getLayoutParams:()Landroid/view/ViewGroup$LayoutParams;:GetGetLayoutParametersHandler\n" +
			"n_setLayoutParams:(Landroid/view/ViewGroup$LayoutParams;)V:GetSetLayoutParameters_Landroid_view_ViewGroup_LayoutParams_Handler\n" +
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.AndroidGestureView`1, Zebble", AndroidGestureView_1.class, __md_methods);
	}


	public AndroidGestureView_1 (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AndroidGestureView_1.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidGestureView`1, Zebble", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public AndroidGestureView_1 (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AndroidGestureView_1.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidGestureView`1, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public AndroidGestureView_1 (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == AndroidGestureView_1.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidGestureView`1, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public AndroidGestureView_1 (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == AndroidGestureView_1.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidGestureView`1, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
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


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);

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

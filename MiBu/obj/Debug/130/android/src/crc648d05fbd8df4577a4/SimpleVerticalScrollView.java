package crc648d05fbd8df4577a4;


public class SimpleVerticalScrollView
	extends android.widget.ScrollView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onSizeChanged:(IIII)V:GetOnSizeChanged_IIIIHandler\n" +
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_dispatchTouchEvent:(Landroid/view/MotionEvent;)Z:GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onInterceptTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnInterceptTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onScrollChanged:(IIII)V:GetOnScrollChanged_IIIIHandler\n" +
			"n_draw:(Landroid/graphics/Canvas;)V:GetDraw_Landroid_graphics_Canvas_Handler\n" +
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.SimpleVerticalScrollView, Zebble", SimpleVerticalScrollView.class, __md_methods);
	}


	public SimpleVerticalScrollView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == SimpleVerticalScrollView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.SimpleVerticalScrollView, Zebble", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public SimpleVerticalScrollView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SimpleVerticalScrollView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.SimpleVerticalScrollView, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public SimpleVerticalScrollView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SimpleVerticalScrollView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.SimpleVerticalScrollView, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public SimpleVerticalScrollView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == SimpleVerticalScrollView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.SimpleVerticalScrollView, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public void onSizeChanged (int p0, int p1, int p2, int p3)
	{
		n_onSizeChanged (p0, p1, p2, p3);
	}

	private native void n_onSizeChanged (int p0, int p1, int p2, int p3);


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);


	public boolean dispatchTouchEvent (android.view.MotionEvent p0)
	{
		return n_dispatchTouchEvent (p0);
	}

	private native boolean n_dispatchTouchEvent (android.view.MotionEvent p0);


	public boolean onInterceptTouchEvent (android.view.MotionEvent p0)
	{
		return n_onInterceptTouchEvent (p0);
	}

	private native boolean n_onInterceptTouchEvent (android.view.MotionEvent p0);


	public void onScrollChanged (int p0, int p1, int p2, int p3)
	{
		n_onScrollChanged (p0, p1, p2, p3);
	}

	private native void n_onScrollChanged (int p0, int p1, int p2, int p3);


	public void draw (android.graphics.Canvas p0)
	{
		n_draw (p0);
	}

	private native void n_draw (android.graphics.Canvas p0);

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

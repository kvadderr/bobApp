package com.dolphin.seekbar;


@android.annotation.TargetApi(
value = 8)
public class RangeSeekbar
	extends android.view.View
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_setPadding:(IIII)V:GetSetPadding_IIIIHandler\n" +
			"n_onMeasure:(II)V:GetOnMeasure_IIHandler\n" +
			"n_onDraw:(Landroid/graphics/Canvas;)V:GetOnDraw_Landroid_graphics_Canvas_Handler\n" +
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_computeScroll:()V:GetComputeScrollHandler\n" +
			"";
		mono.android.Runtime.register ("Com.Dolphin.SeekBarLib.RangeSeekbar, RangeSeekbar", RangeSeekbar.class, __md_methods);
	}


	public RangeSeekbar (android.content.Context p0)
	{
		super (p0);
		if (getClass () == RangeSeekbar.class) {
			mono.android.TypeManager.Activate ("Com.Dolphin.SeekBarLib.RangeSeekbar, RangeSeekbar", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public RangeSeekbar (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == RangeSeekbar.class) {
			mono.android.TypeManager.Activate ("Com.Dolphin.SeekBarLib.RangeSeekbar, RangeSeekbar", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public RangeSeekbar (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == RangeSeekbar.class) {
			mono.android.TypeManager.Activate ("Com.Dolphin.SeekBarLib.RangeSeekbar, RangeSeekbar", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public RangeSeekbar (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == RangeSeekbar.class) {
			mono.android.TypeManager.Activate ("Com.Dolphin.SeekBarLib.RangeSeekbar, RangeSeekbar", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public void setPadding (int p0, int p1, int p2, int p3)
	{
		n_setPadding (p0, p1, p2, p3);
	}

	private native void n_setPadding (int p0, int p1, int p2, int p3);


	public void onMeasure (int p0, int p1)
	{
		n_onMeasure (p0, p1);
	}

	private native void n_onMeasure (int p0, int p1);


	public void onDraw (android.graphics.Canvas p0)
	{
		n_onDraw (p0);
	}

	private native void n_onDraw (android.graphics.Canvas p0);


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);


	public void computeScroll ()
	{
		n_computeScroll ();
	}

	private native void n_computeScroll ();

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

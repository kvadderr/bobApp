package crc648d05fbd8df4577a4;


public class AndroidImageView
	extends android.widget.ImageView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_setImageBitmap:(Landroid/graphics/Bitmap;)V:GetSetImageBitmap_Landroid_graphics_Bitmap_Handler\n" +
			"n_setFrame:(IIII)Z:GetSetFrame_IIIIHandler\n" +
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.AndroidImageView, Zebble", AndroidImageView.class, __md_methods);
	}


	public AndroidImageView (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AndroidImageView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidImageView, Zebble", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public AndroidImageView (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AndroidImageView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidImageView, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public AndroidImageView (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == AndroidImageView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidImageView, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public AndroidImageView (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == AndroidImageView.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidImageView, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public void setImageBitmap (android.graphics.Bitmap p0)
	{
		n_setImageBitmap (p0);
	}

	private native void n_setImageBitmap (android.graphics.Bitmap p0);


	public boolean setFrame (int p0, int p1, int p2, int p3)
	{
		return n_setFrame (p0, p1, p2, p3);
	}

	private native boolean n_setFrame (int p0, int p1, int p2, int p3);

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

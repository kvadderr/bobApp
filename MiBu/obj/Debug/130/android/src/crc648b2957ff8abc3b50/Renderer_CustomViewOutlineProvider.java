package crc648b2957ff8abc3b50;


public class Renderer_CustomViewOutlineProvider
	extends android.view.ViewOutlineProvider
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getOutline:(Landroid/view/View;Landroid/graphics/Outline;)V:GetGetOutline_Landroid_view_View_Landroid_graphics_Outline_Handler\n" +
			"";
		mono.android.Runtime.register ("Zebble.Renderer+CustomViewOutlineProvider, Zebble", Renderer_CustomViewOutlineProvider.class, __md_methods);
	}


	public Renderer_CustomViewOutlineProvider ()
	{
		super ();
		if (getClass () == Renderer_CustomViewOutlineProvider.class) {
			mono.android.TypeManager.Activate ("Zebble.Renderer+CustomViewOutlineProvider, Zebble", "", this, new java.lang.Object[] {  });
		}
	}


	public void getOutline (android.view.View p0, android.graphics.Outline p1)
	{
		n_getOutline (p0, p1);
	}

	private native void n_getOutline (android.view.View p0, android.graphics.Outline p1);

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

package crc648d05fbd8df4577a4;


public class MyLayoutListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.ViewTreeObserver.OnGlobalLayoutListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onGlobalLayout:()V:GetOnGlobalLayoutHandler:Android.Views.ViewTreeObserver/IOnGlobalLayoutListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.MyLayoutListener, Zebble", MyLayoutListener.class, __md_methods);
	}


	public MyLayoutListener ()
	{
		super ();
		if (getClass () == MyLayoutListener.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.MyLayoutListener, Zebble", "", this, new java.lang.Object[] {  });
		}
	}


	public void onGlobalLayout ()
	{
		n_onGlobalLayout ();
	}

	private native void n_onGlobalLayout ();

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

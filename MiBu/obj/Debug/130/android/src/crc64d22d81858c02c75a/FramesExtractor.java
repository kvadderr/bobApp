package crc64d22d81858c02c75a;


public class FramesExtractor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.Gif.FramesExtractor, Zebble", FramesExtractor.class, __md_methods);
	}


	public FramesExtractor ()
	{
		super ();
		if (getClass () == FramesExtractor.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.Gif.FramesExtractor, Zebble", "", this, new java.lang.Object[] {  });
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

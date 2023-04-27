package crc648b2957ff8abc3b50;


public class JavaWrapper
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_toString:()Ljava/lang/String;:GetToStringHandler\n" +
			"";
		mono.android.Runtime.register ("Zebble.JavaWrapper, Zebble", JavaWrapper.class, __md_methods);
	}


	public JavaWrapper ()
	{
		super ();
		if (getClass () == JavaWrapper.class) {
			mono.android.TypeManager.Activate ("Zebble.JavaWrapper, Zebble", "", this, new java.lang.Object[] {  });
		}
	}


	public java.lang.String toString ()
	{
		return n_toString ();
	}

	private native java.lang.String n_toString ();

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

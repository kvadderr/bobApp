package crc648304ad725069742e;


public class BottomSelectProfile_2
	extends androidx.fragment.app.Fragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MiBu.BottomSelectProfile_2, MiBu", BottomSelectProfile_2.class, __md_methods);
	}


	public BottomSelectProfile_2 ()
	{
		super ();
		if (getClass () == BottomSelectProfile_2.class) {
			mono.android.TypeManager.Activate ("MiBu.BottomSelectProfile_2, MiBu", "", this, new java.lang.Object[] {  });
		}
	}


	public BottomSelectProfile_2 (int p0)
	{
		super (p0);
		if (getClass () == BottomSelectProfile_2.class) {
			mono.android.TypeManager.Activate ("MiBu.BottomSelectProfile_2, MiBu", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);

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
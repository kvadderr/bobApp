package crc648304ad725069742e;


public class ModalSendKarma
	extends androidx.fragment.app.DialogFragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDismiss:(Landroid/content/DialogInterface;)V:GetOnDismiss_Landroid_content_DialogInterface_Handler\n" +
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"n_onActivityCreated:(Landroid/os/Bundle;)V:GetOnActivityCreated_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("MiBu.ModalSendKarma, MiBu", ModalSendKarma.class, __md_methods);
	}


	public ModalSendKarma ()
	{
		super ();
		if (getClass () == ModalSendKarma.class) {
			mono.android.TypeManager.Activate ("MiBu.ModalSendKarma, MiBu", "", this, new java.lang.Object[] {  });
		}
	}


	public void onDismiss (android.content.DialogInterface p0)
	{
		n_onDismiss (p0);
	}

	private native void n_onDismiss (android.content.DialogInterface p0);


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);


	public void onActivityCreated (android.os.Bundle p0)
	{
		n_onActivityCreated (p0);
	}

	private native void n_onActivityCreated (android.os.Bundle p0);

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

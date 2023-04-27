package crc648d05fbd8df4577a4;


public class AndroidTextInput
	extends android.widget.EditText
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onEditorAction:(I)V:GetOnEditorAction_IHandler\n" +
			"n_onTextChanged:(Ljava/lang/CharSequence;III)V:GetOnTextChanged_Ljava_lang_CharSequence_IIIHandler\n" +
			"n_onFocusChanged:(ZILandroid/graphics/Rect;)V:GetOnFocusChanged_ZILandroid_graphics_Rect_Handler\n" +
			"n_dispatchTouchEvent:(Landroid/view/MotionEvent;)Z:GetDispatchTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onKeyPreIme:(ILandroid/view/KeyEvent;)Z:GetOnKeyPreIme_ILandroid_view_KeyEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("Zebble.AndroidOS.AndroidTextInput, Zebble", AndroidTextInput.class, __md_methods);
	}


	public AndroidTextInput (android.content.Context p0)
	{
		super (p0);
		if (getClass () == AndroidTextInput.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidTextInput, Zebble", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public AndroidTextInput (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == AndroidTextInput.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidTextInput, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public AndroidTextInput (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == AndroidTextInput.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidTextInput, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public AndroidTextInput (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == AndroidTextInput.class) {
			mono.android.TypeManager.Activate ("Zebble.AndroidOS.AndroidTextInput, Zebble", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public void onEditorAction (int p0)
	{
		n_onEditorAction (p0);
	}

	private native void n_onEditorAction (int p0);


	public void onTextChanged (java.lang.CharSequence p0, int p1, int p2, int p3)
	{
		n_onTextChanged (p0, p1, p2, p3);
	}

	private native void n_onTextChanged (java.lang.CharSequence p0, int p1, int p2, int p3);


	public void onFocusChanged (boolean p0, int p1, android.graphics.Rect p2)
	{
		n_onFocusChanged (p0, p1, p2);
	}

	private native void n_onFocusChanged (boolean p0, int p1, android.graphics.Rect p2);


	public boolean dispatchTouchEvent (android.view.MotionEvent p0)
	{
		return n_dispatchTouchEvent (p0);
	}

	private native boolean n_dispatchTouchEvent (android.view.MotionEvent p0);


	public boolean onKeyPreIme (int p0, android.view.KeyEvent p1)
	{
		return n_onKeyPreIme (p0, p1);
	}

	private native boolean n_onKeyPreIme (int p0, android.view.KeyEvent p1);

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

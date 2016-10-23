package md502013eb3a064cb52b7e6e65d56b24042;


public class ListWithHeaders
	extends android.app.ListActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Mono.Samples.LabelledSections.ListWithHeaders, Mono.Samples.LabelledSections, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ListWithHeaders.class, __md_methods);
	}


	public ListWithHeaders () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ListWithHeaders.class)
			mono.android.TypeManager.Activate ("Mono.Samples.LabelledSections.ListWithHeaders, Mono.Samples.LabelledSections, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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

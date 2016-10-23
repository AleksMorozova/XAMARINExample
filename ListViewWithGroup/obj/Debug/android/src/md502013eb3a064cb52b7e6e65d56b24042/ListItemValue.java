package md502013eb3a064cb52b7e6e65d56b24042;


public class ListItemValue
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
		mono.android.Runtime.register ("Mono.Samples.LabelledSections.ListItemValue, Mono.Samples.LabelledSections, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ListItemValue.class, __md_methods);
	}


	public ListItemValue () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ListItemValue.class)
			mono.android.TypeManager.Activate ("Mono.Samples.LabelledSections.ListItemValue, Mono.Samples.LabelledSections, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public ListItemValue (java.lang.String p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == ListItemValue.class)
			mono.android.TypeManager.Activate ("Mono.Samples.LabelledSections.ListItemValue, Mono.Samples.LabelledSections, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0 });
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

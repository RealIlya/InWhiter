package crc64ce23cfcb00cd8968;


public class MySwitchRender
	extends crc64720bb2db43a66fe9.SwitchRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("InWhiter.Android.MySwitchRender, InWhiter.Android", MySwitchRender.class, __md_methods);
	}


	public MySwitchRender (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MySwitchRender.class)
			mono.android.TypeManager.Activate ("InWhiter.Android.MySwitchRender, InWhiter.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public MySwitchRender (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MySwitchRender.class)
			mono.android.TypeManager.Activate ("InWhiter.Android.MySwitchRender, InWhiter.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MySwitchRender (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MySwitchRender.class)
			mono.android.TypeManager.Activate ("InWhiter.Android.MySwitchRender, InWhiter.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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

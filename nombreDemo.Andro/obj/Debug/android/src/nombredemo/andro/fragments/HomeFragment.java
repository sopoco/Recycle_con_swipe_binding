package nombredemo.andro.fragments;


public class HomeFragment
	extends md50cdffa1a918f81198a163b4fc16e2a88.BaseFragment_1
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("nombreDemo.Andro.Fragments.HomeFragment, nombreDemo.Andro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", HomeFragment.class, __md_methods);
	}


	public HomeFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == HomeFragment.class)
			mono.android.TypeManager.Activate ("nombreDemo.Andro.Fragments.HomeFragment, nombreDemo.Andro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
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

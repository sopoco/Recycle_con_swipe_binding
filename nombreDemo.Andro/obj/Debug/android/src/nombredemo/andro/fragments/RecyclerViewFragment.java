package nombredemo.andro.fragments;


public class RecyclerViewFragment
	extends md50cdffa1a918f81198a163b4fc16e2a88.BaseFragment_1
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"n_onDestroyView:()V:GetOnDestroyViewHandler\n" +
			"";
		mono.android.Runtime.register ("nombreDemo.Andro.Fragments.RecyclerViewFragment, nombreDemo.Andro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RecyclerViewFragment.class, __md_methods);
	}


	public RecyclerViewFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RecyclerViewFragment.class)
			mono.android.TypeManager.Activate ("nombreDemo.Andro.Fragments.RecyclerViewFragment, nombreDemo.Andro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);


	public void onDestroyView ()
	{
		n_onDestroyView ();
	}

	private native void n_onDestroyView ();

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

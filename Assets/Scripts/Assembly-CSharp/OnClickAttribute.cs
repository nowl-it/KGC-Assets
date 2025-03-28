using System;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class OnClickAttribute : Attribute
{
	private string _name;

	private bool _inChildren;

	public string name => null;

	public bool inChildren => false;

	public OnClickAttribute(string name, bool inChildren = false)
	{
	}
}

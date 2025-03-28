using System;

[AttributeUsage(AttributeTargets.Field)]
public class ComponentConnectAttribute : Attribute
{
	private string _name;

	private bool _inChildren;

	public string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool inChildren => false;

	public ComponentConnectAttribute(string name, bool inChildren = false)
	{
	}

	public ComponentConnectAttribute()
	{
	}
}

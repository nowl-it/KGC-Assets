using System;
using System.Xml;
using UnityEngine;

public class ResourceEmoticon : ResourceBase<ResourceEmoticon>
{
	private string _spriteKey;

	public Sprite sprite => null;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}

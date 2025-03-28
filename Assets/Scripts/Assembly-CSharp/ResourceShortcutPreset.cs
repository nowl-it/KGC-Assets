using System;
using System.Xml;

public class ResourceShortcutPreset : ResourceBase<ResourceShortcutPreset>
{
	private string _nameKey;

	private string _alertKey;

	public LobbyShortCutController.ShortCutInfo shortCutInfo;

	public new string name => null;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}

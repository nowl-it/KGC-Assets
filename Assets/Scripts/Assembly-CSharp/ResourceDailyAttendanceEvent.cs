using System;
using System.Collections.Generic;
using System.Xml;

public class ResourceDailyAttendanceEvent : ResourceBase<ResourceDailyAttendanceEvent>
{
	public int eventId;

	public int day;

	public int keyId;

	public int keyCount;

	public int unitExpCount;

	public int gold;

	public int cash;

	public int eventFlag;

	public int newUnitGacha;

	public int heart;

	public string icon;

	public int inventoryItem;

	public int inventoryItemCount;

	private static Dictionary<int, Dictionary<int, ResourceDailyAttendanceEvent>> sortedData;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}

	public static int GetEventSize(int eventId)
	{
		return 0;
	}

	public static ResourceDailyAttendanceEvent Get(int eventId, int day)
	{
		return null;
	}
}

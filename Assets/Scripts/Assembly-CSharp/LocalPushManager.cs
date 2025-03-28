using System;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class LocalPushManager : MonoBehaviour
{
	private bool isInited;

	private const string CHANNEL_ID = "kgcastle";

	private const string CHANNEL_NAME = "King God Castle";

	private const string CHANNEL_DESC = "King God Castle Notification";

	private const string ICON_SMALL = "icon_small";

	private const string ICON_LARGE = "icon_large";

	private List<string> _androidNotifications;

	private List<AndroidNotification> _datas;

	private List<int> idList;

	private void Start()
	{
	}

	public void Init()
	{
	}

	public void RegisterNotifications()
	{
	}

	private List<LocalPushItemData> GetLocalPushItemDatas(ResourceLocalPushItem pushItem)
	{
		return null;
	}

	private bool ConditionCheck(ResourceLocalPushItem pushItem)
	{
		return false;
	}

	private bool ConditionCheck(LocalPushItemData itemData)
	{
		return false;
	}

	public TimeSpan GetFireTime(ResourceLocalPushItem pushItem)
	{
		return default(TimeSpan);
	}

	private void Register(ResourceLocalPushItem pushItem)
	{
	}

	private void Register(LocalPushItemData itemData)
	{
	}

	public void OnApplicationFocus(bool focus)
	{
	}

	public void FlushForTest()
	{
	}

	private void ClearAllScheduledNotifications()
	{
	}

	private void InitAndroid()
	{
	}

	private void OnNotificationReceivedAndroid(AndroidNotificationIntentData data)
	{
	}

	private int RegisterAndroid(ResourceLocalPushItem pushItem, LocalPushItemData itemData = null)
	{
		return 0;
	}

	private void HandleAndroidNotificationScheduled()
	{
	}

	private void ClearAndroid()
	{
	}

	private void FlushAndroidForTest()
	{
	}

	public void CheckStatusAndroidForTest()
	{
	}

	public void CheckStatusAndroidForTest(int id)
	{
	}

	public void RemoveAndroidForTest()
	{
	}

	public void RemoveAndroidForTest(int id)
	{
	}
}

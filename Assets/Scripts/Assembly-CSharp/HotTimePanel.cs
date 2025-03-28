using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class HotTimePanel : MonoBehaviour, IClosable
{
	public static HotTimePanel Instance;

	public Text leftTime;

	public Text desc;

	public static EventMissionData hotTimeEventData => null;

	public void Awake()
	{
	}

	public void Show()
	{
	}

	public void Update()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}

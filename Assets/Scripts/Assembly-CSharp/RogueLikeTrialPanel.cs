using System;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeTrialPanel : MonoBehaviour
{
	[Serializable]
	public struct SaveData
	{
		public int eventTriggerId;
	}

	private static RogueLikeTrialPanel _instance;

	[SerializeField]
	private Text _trialDescText;

	[SerializeField]
	private Border _ribbon;

	[SerializeField]
	private CanvasGroup _trialBoxCG;

	[SerializeField]
	private CanvasGroup _rewardBoxCG;

	[SerializeField]
	private CanvasGroup _buttonsCG;

	private static ResourceEventTrigger _eventTrigger;

	private bool _setBG;

	public static RogueLikeTrialPanel Instance => null;

	private void SetBG()
	{
	}

	public void Show()
	{
	}

	private void ShowImpl()
	{
	}

	private ResourceEventTrigger GetRandomTrial()
	{
		return null;
	}

	public void Close()
	{
	}

	public void OnClickAccept()
	{
	}

	public void OnClickDecline()
	{
	}

	public static SaveData ToSaveData()
	{
		return default(SaveData);
	}

	public void LoadFromSaveDataAndShow(SaveData saveData)
	{
	}
}

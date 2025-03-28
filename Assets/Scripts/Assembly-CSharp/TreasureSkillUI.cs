using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class TreasureSkillUI : MonoBehaviour
{
	public new GameObject gameObject;

	public Image skillIcon;

	public Text treasureLevel;

	public Gauge treasureExp;

	public Text skillNameText;

	public Text skillDescText;

	[SerializeField]
	private GameObject _previewButtonsObj;

	private TreasureModel _treasure;

	private Action<TreasureModel> _beforePreviewChangedAction;

	public TreasureModel clonedTreasure => null;

	public void Set(TreasureModel treasure)
	{
	}

	public void SetPreviewObjectActive(bool active, Action<TreasureModel> beforePreviewChangedAction = null)
	{
	}

	private void OnDestroy()
	{
	}

	public void Reload()
	{
	}

	public void OnClickPreviewButton(int idx)
	{
	}
}

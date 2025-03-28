using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitInfoPanel : MonoBehaviour
{
	public static UnitInfoPanel Instance;

	public UnitInfoPanelBase unitInfoPanel;

	[GetComponent]
	public RectTransform rectTransform;

	[GetComponent]
	public CanvasGroup canvasGroup;

	public ItemInfoPanel[] itemInfoPanels;

	[SerializeField]
	private Button _advancedInfoButton;

	[SerializeField]
	private List<UIFitter> _uiFitters;

	private GameUnit _target;

	private float _timeLimit;

	private static ulong _showUnitInfoPanelHash;

	public void Awake()
	{
	}

	public void Show(GameUnit target, Vector2 pos)
	{
	}

	public void Hide()
	{
	}

	public void ShowRange(bool show, bool skill = false)
	{
	}

	public void OnClickSkillArea()
	{
	}

	public void Reload()
	{
	}

	public void Update()
	{
	}

	private ResourceSkill GetCurrentSkill()
	{
		return null;
	}

	public void ReloadSkillDesc(bool ignoreLastSkill = false)
	{
	}

	public void OnClickAdvancedInfoPanel()
	{
	}
}

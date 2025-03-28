using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumAbilitySelectPanel : MonoBehaviour
{
	private static ColosseumAbilitySelectPanel _instance;

	private TerritoryBonusUnitTooltip _territoryBonusUnitTooltip;

	[SerializeField]
	private TextFitter _titleTextFitter;

	[SerializeField]
	private Border _titleRibbonBorder;

	[SerializeField]
	private FlexibleUIElements _abilityItemElements;

	[SerializeField]
	private ConditionalGroup _selectButtonConditionals;

	[SerializeField]
	private Text _abilityRerollCountText;

	private int _abilityRerollCount;

	private BattleManager _battleManager;

	private List<ResourceColosseumAbility> _pickedAbilities;

	private int _selectedIndex;

	private bool _setBG;

	private const int ABILITY_PICK_COUNT = 3;

	public static ColosseumAbilitySelectPanel Instance => null;

	public TerritoryBonusUnitTooltip territoryBonusUnitTooltip => null;

	private void SetBG()
	{
	}

	public void Show(BattleManager battleManager)
	{
	}

	private void SelectItem(int index)
	{
	}

	public void OnClickSelectButton()
	{
	}

	public void OnClickPendingButton()
	{
	}

	public void Close()
	{
	}

	public static List<ResourceColosseumAbility> PickRandomAbilities(BattleManager battleManager, int abilityLevel, int count, bool reroll = false)
	{
		return null;
	}

	public void ShowAbilityInfo(ResourceColosseumAbility resAbility, Vector3 position)
	{
	}

	private void Reroll(int index)
	{
	}

	private void UpdateRerollCount()
	{
	}
}

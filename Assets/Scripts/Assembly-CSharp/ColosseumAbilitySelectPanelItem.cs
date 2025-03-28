using UnityEngine;
using UnityEngine.UI;

public class ColosseumAbilitySelectPanelItem : MonoBehaviour
{
	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private GameObject _selectedObject;

	[SerializeField]
	private GameObject _unselectedObject;

	[SerializeField]
	private Button _infoButton;

	public Button rerollButton;

	[SerializeField]
	private ConditionalGroup _canRerollCondition;

	private ResourceColosseumAbility _resAbility;

	public void UpdateRerollCondition(int rerollCount)
	{
	}

	public void Set(BattleManager battleManager, ResourceColosseumAbility resAbility)
	{
	}

	public void SetSelected(bool isSelected, bool showUnselectedObject)
	{
	}

	public void OnClickInfo()
	{
	}
}

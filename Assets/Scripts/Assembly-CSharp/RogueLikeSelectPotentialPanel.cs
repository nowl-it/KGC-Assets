using UnityEngine;
using UnityEngine.UI;

public class RogueLikeSelectPotentialPanel : MonoBehaviour
{
	private static RogueLikeSelectPotentialPanel _instance;

	[SerializeField]
	private UnitIllust _unitIllust;

	[SerializeField]
	private PotentialButton[] _potentialButtons;

	[SerializeField]
	private ClickOutsideClose _potentialDescPanel;

	[SerializeField]
	private Text _potentialDescText;

	[SerializeField]
	private ConditionalGroup _confirmButtonConditionals;

	private ResourceUnit.Potential[] _potentials;

	private RogueLikeCardData _targetCard;

	private int _selectedPotential;

	public static RogueLikeSelectPotentialPanel Instance => null;

	public void Show(RogueLikeCardData targetCard)
	{
	}

	private void OnClickPotentialButton(PotentialButton button)
	{
	}

	public void OnClickConfirm()
	{
	}

	public bool Close()
	{
		return false;
	}
}

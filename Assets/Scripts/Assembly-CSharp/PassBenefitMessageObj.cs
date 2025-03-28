using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PassBenefitMessageObj : MonoBehaviour
{
	[SerializeField]
	private GameObject _cell1;

	[SerializeField]
	private ConditionalGroup _passActiveCond;

	[SerializeField]
	private ConditionalGroup _passButtonCond;

	[SerializeField]
	private GameObject _cell2;

	[SerializeField]
	private ConditionalGroup _buyPassCond;

	[SerializeField]
	private Text _cell2ButtonText;

	[SerializeField]
	private GameObject _leftButton;

	[SerializeField]
	private GameObject _rightButton;

	[SerializeField]
	private SwipeHandler _swipeHandler;

	[Space(20f)]
	[SerializeField]
	private int _targetPass;

	[SerializeField]
	private bool _closePopupsAtShortcut;

	[SerializeField]
	private UnityEvent _onBuyPass;

	private int _curIdx;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	public void OnClickArrow(int idx)
	{
	}

	public void OnClickBuyButton()
	{
	}

	private void DoShortcut(string shortcutKey)
	{
	}
}

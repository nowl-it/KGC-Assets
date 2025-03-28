using UnityEngine;
using UnityEngine.UI;

public class BabelBasePanelBox : MonoBehaviour
{
	[SerializeField]
	private Text _babelText;

	[SerializeField]
	private Button _giveUpButton;

	[SerializeField]
	private Button _restartButton;

	[SerializeField]
	private Image _flagIcon;

	[SerializeField]
	private Animator _babelFloorAnimator;

	[SerializeField]
	private Animator _babelStartButton;

	[SerializeField]
	private Animator _babelStartSubButton;

	private static readonly int _babelFloorInt;

	private static readonly int _babelFloorAnimTrigger;

	private const int NONE = -1;

	private const int FIRST_FLOOR = 0;

	private const int MIDDLE_FLOOR = 1;

	private const int FINAL_BEFORE_FLOOR = 2;

	private const int FINAL_FLOOR = 3;

	private static readonly int _babelStartInt;

	private const int NOT_AUTO = 0;

	private const int AUTO_ON = 1;

	private const int AUTO_OFF = 2;

	public void Init()
	{
	}

	public void ReloadStageText()
	{
	}

	public void OnClickRestartBabel()
	{
	}

	public void OnClickBabelGiveUp()
	{
	}

	private void SetCurrentFloorState()
	{
	}

	public void DoNextFloorAnimation()
	{
	}

	private int GetAnimStateFromFloor(int stage)
	{
		return 0;
	}

	public void ReloadAutoButton(bool set)
	{
	}

	public void SetButtonEnable(bool set)
	{
	}
}

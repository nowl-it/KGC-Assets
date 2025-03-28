using System;
using UnityEngine;
using UnityEngine.UI;

public class GachaNewUnitPanel : PopupPanel, IGachaResult
{
	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private GameObject _newUnitTextObject;

	[SerializeField]
	private Image[] _unitIllusts;

	[SerializeField]
	private Image _unitIllust;

	[SerializeField]
	private Image _unitBackIllust;

	[SerializeField]
	private RectTransform _unitPrefabRoot;

	[SerializeField]
	private Image[] _gradationColorImages;

	[SerializeField]
	private Image[] _darkerGradationColorImages;

	[SerializeField]
	private Image[] _brighterGradationColorImages;

	[SerializeField]
	private Image[] _explosionEffectImages;

	[SerializeField]
	private GameObject _character;

	[SerializeField]
	private GameObject _soulObject;

	[SerializeField]
	private Image _soulUnitAvatar;

	[SerializeField]
	private Text _soulCountText;

	[SerializeField]
	private Text _alchemyGachaItemCountText;

	[SerializeField]
	private ConditionalGroup _soulIconConditional;

	[SerializeField]
	private Text _unitNameText;

	[SerializeField]
	private Text _unitSubNameText;

	[SerializeField]
	private float _darkerGradationColorMultiplier;

	[SerializeField]
	private float _brighterGradationColorMultiplier;

	private Action _closeCallback;

	private GameObject _unitPrefab;

	private bool _isSoul;

	public void Set(int unitId, int skinId, int soulCount, Action closeCallback, bool showAlchemyGachaItem = true)
	{
	}

	public bool CanHide()
	{
		return false;
	}

	public override void Show()
	{
	}

	public void Hide()
	{
	}

	public new void OnClickClose()
	{
	}

	public override bool Close()
	{
		return false;
	}

	public void Skip()
	{
	}
}

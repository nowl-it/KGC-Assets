using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using SRF.UI;
using UnityEngine;
using UnityEngine.UI;

public class AccessoryUIItem : MonoBehaviour
{
	[SerializeField]
	private Image _accessoryIcon;

	[SerializeField]
	private Image _frameIcon;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private Image _mainStatIcon;

	[SerializeField]
	private Image _mainStatIcon_StatGroup;

	[SerializeField]
	private Image _lockIcon;

	[SerializeField]
	private ConditionalGroup _equipCond;

	[SerializeField]
	private List<GameObject> _lockObjects;

	[SerializeField]
	private ConditionalImage _stateCond;

	[SerializeField]
	private ProfileAvatar _unitAvatar;

	[SerializeField]
	private ConditionalSetActive _selectedCond;

	private Image _selectedImage;

	[SerializeField]
	private GameObject _statObj;

	[SerializeField]
	private Text _mainStatText;

	[SerializeField]
	private Image[] _subStatIcons;

	[SerializeField]
	private Text[] _subStatTexts;

	[SerializeField]
	private SRF.UI.LongPressButton _longPressButton;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private Text _coolTimeText;

	[SerializeField]
	private UIGrayScaler _grayScaler;

	[SerializeField]
	private ConditionalBase _usedObj;

	private Action _onClick;

	private Action _onLongPress;

	private AccessoryModel _accessory;

	private Color _prevColor;

	public void Set(AccessoryModel accessory, bool showStatUI, CardData cardData, Action onClick = null, Action onLongPress = null, bool showAvatar = true, bool showCoolTimeText = false, bool showMainStatIcon = true, AccessoryModel[] equippedAccessories = null)
	{
	}

	public void SetDefault(bool locked, Action onClick = null, Action onLongPress = null)
	{
	}

	private void Update()
	{
	}

	public void OnClick()
	{
	}

	public void OnLongPress()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetSelected(bool selected, Color? color = null)
	{
	}

	public void SetAlpha(float a)
	{
	}

	public void SetGrayScale(bool set)
	{
	}

	public void SetUsed(bool used)
	{
	}
}

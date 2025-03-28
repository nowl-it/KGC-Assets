using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeSelectFirstBuildingPanelBuildingItem : MonoBehaviour
{
	[Serializable]
	public struct LockBuildingObj
	{
		public GameObject gameObject;

		public Text nameText;
	}

	[SerializeField]
	private ConditionalGroup _altarCond;

	[SerializeField]
	private Image _altarEffect;

	[SerializeField]
	private Image _altarEffectNone;

	[SerializeField]
	private Animator _altarFlame;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private List<Text> _descTexts;

	[SerializeField]
	private List<TextFitter> _descTextFitters;

	[SerializeField]
	private List<Image> _descEffects;

	[SerializeField]
	private ConditionalGroup _buttonCond;

	[SerializeField]
	private LockBuildingObj _unLockObj;

	[SerializeField]
	private GameObject _outlineObjects;

	[SerializeField]
	private Image[] _buildingColorImages;

	[SerializeField]
	private float _outlineEffectDuration;

	private int _buildingId;

	private Sequence[] _descEffectSequences;

	private bool _isSelected => false;

	public void Set(int buildingId, bool selected)
	{
	}

	private void Reload(bool effect = true)
	{
	}

	public void OnClickSelectButton()
	{
	}

	public void OnClickUnLockBuilding()
	{
	}
}

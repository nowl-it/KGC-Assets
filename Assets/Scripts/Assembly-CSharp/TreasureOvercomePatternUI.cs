using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class TreasureOvercomePatternUI : MonoBehaviour
{
	private static readonly int _starAnimHashOff;

	private static readonly int _starAnimHashOn;

	private const float _lightEffectTweenLength = 1.83f;

	[SerializeField]
	private List<Animator> _overcomeStars;

	public Image[] overcomeStarActivatedObjs;

	[SerializeField]
	private GameObject _linePrefab;

	private List<Animator> _overcomeLineEffects;

	private float _lineLightEffectTimer;

	private TreasureOvercomePanel _overcomePanel;

	private TreasureModel _treasure;

	public List<Animator> overcomeStars => null;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void Set(TreasureModel treasure, TreasureOvercomePanel overcomePanel)
	{
	}

	public void ShowOvercomeInformation(int idx)
	{
	}

	public void SetSelectedIndex(int idx)
	{
	}

	public void SetStarEffect(int end)
	{
	}
}

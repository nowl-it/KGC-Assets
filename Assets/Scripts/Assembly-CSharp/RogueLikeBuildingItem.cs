using Coffee.UIEffects;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeBuildingItem : MonoBehaviour
{
	public Animator altar;

	public Animator flameCenter;

	public Animator[] bottomFlames;

	public Animator[] sideFlame;

	public Text levelText;

	public UIShadow levelOutline;

	public Text nameText;

	public Text[] descText;

	public Image[] descEffect;

	public GameObject lastOptionPartition;

	public Sequence[] descEffectSequence;

	public ConditionalGroup altarCond;

	public ConditionalGroup altarStateCond;

	public Button infoButton;

	[HideInInspector]
	public BuildingData buildingData;

	private Sequence _altarTween;

	private Tween _levelTween;

	private static readonly int Level;

	private static readonly int LevelInt;

	private static readonly int LevelUp;

	private static readonly int Index;

	private int _currentLevel => 0;

	public void Init()
	{
	}

	public void Set(BuildingData buildingData, bool effect = false, bool hasHiddenOption = false, bool longVersion = false)
	{
	}

	private void Reload(bool effect, bool hasHiddenOption = false, bool longVersion = false)
	{
	}
}

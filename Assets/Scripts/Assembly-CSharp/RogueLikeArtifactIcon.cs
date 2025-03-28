using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RogueLikeArtifactIcon : MonoBehaviour
{
	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Image _frameImage;

	[SerializeField]
	private RectTransform _bgRectTransform;

	[SerializeField]
	private Image _bg;

	[SerializeField]
	private ConditionalGroup _equippedConditionals;

	[SerializeField]
	private Image[] _buildingIcons;

	[SerializeField]
	private AwesomeOutline[] _buildingIconOutlines;

	[SerializeField]
	private Text[] _buildingTexts;

	[SerializeField]
	private UIEffect[] _selectedEffect;

	[SerializeField]
	private ConditionalImage _starIcon;

	private RogueLikeArtifactModel _model;

	private int[] _oldBuildingIds;

	private int[] _oldBuildingLevels;

	private Color _originEffectColor;

	public RogueLikeArtifactModel model => null;

	public void Set(RogueLikeArtifactModel model, bool showEffect = true)
	{
	}

	public bool IsPointerOver(PointerEventData eventData)
	{
		return false;
	}

	public void SetSelected(int set)
	{
	}

	public void ShowArtifactEffect()
	{
	}
}

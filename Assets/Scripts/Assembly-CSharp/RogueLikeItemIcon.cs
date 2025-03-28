using UnityEngine;
using UnityEngine.UI;

public class RogueLikeItemIcon : MonoBehaviour
{
	[SerializeField]
	private ConditionalGroup _selectedConditionals;

	[SerializeField]
	private Image _bg;

	[SerializeField]
	private Image _frameImage;

	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private ConditionalImage _unitLevelImageConditionals;

	[SerializeField]
	private Text _unitLevelText;

	[SerializeField]
	private Text _artifactFixedBuildingText;

	[SerializeField]
	private Image _artifactFixedBuildingIcon;

	[SerializeField]
	private Text _artifactRandomBuildingText;

	[SerializeField]
	private Image _artifactRandomBuildingIcon;

	[SerializeField]
	private ConditionalImage _equippedUnitFrameConditionalImage;

	[SerializeField]
	private Image _equippedUnitImage;

	[SerializeField]
	private ConditionalImage _starIcon;

	private Vector2 _iconOriginSize;

	private AwesomeOutline _artifactRandomBuildingTextOutline;

	private AwesomeOutline _artifactFixedBuildingIconOutline;

	private AwesomeOutline _artifactRandomBuildingIconOutline;

	private void Init()
	{
	}

	public void SetItem(Item item)
	{
	}

	public void SetItem(ResourceItem resItem)
	{
	}

	public void SetArtifact(ResourceArtifact resArtifact, RogueLikeArtifactModel model, bool showBuildingAtIcon)
	{
	}

	public void SetHero(ResourceUnit resUnit, int level, bool own)
	{
	}

	public void SetGold(int tier)
	{
	}

	public void SetCustom(Sprite icon, int tier)
	{
	}

	private void SetFrame(int tier)
	{
	}

	private void ShowIconFrontOfFrame(bool set)
	{
	}

	public void SetEquipped(GameUnit by)
	{
	}

	public void SetSelected(bool set)
	{
	}
}

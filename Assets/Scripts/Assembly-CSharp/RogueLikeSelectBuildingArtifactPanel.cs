using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeSelectBuildingArtifactPanel : MonoBehaviour, IClosable
{
	private static RogueLikeSelectBuildingArtifactPanel _instance;

	[SerializeField]
	private RogueLikeArtifactIcon[] _artifactIcons;

	[SerializeField]
	private ConditionalGroup[] _artifactIconsSelectedConditionals;

	[SerializeField]
	private Text _panelDesc;

	[SerializeField]
	private Text _artifactNameText;

	[SerializeField]
	private Text _artifactTierText;

	[SerializeField]
	private Text _artifactOptionText;

	[SerializeField]
	private Text _artifactDescText;

	[SerializeField]
	private Border _ribbon;

	private readonly List<RogueLikeArtifactModel> _artifactModels;

	private int _selectedIndex;

	private static string[] sounds;

	public static RogueLikeSelectBuildingArtifactPanel Instance => null;

	public void Show()
	{
	}

	public void OnClickArtifactIcon(int index)
	{
	}

	public void OnClickReceive()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}

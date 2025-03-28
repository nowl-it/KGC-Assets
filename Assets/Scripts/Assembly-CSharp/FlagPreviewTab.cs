using UnityEngine;
using UnityEngine.UI;

public class FlagPreviewTab : MonoBehaviour
{
	public FlagItem flagItem;

	public RectTransform flagParent;

	[ComponentConnect]
	public Text flagNameText;

	[ComponentConnect]
	public Text flagDescText;

	private Vector3 _originPos;

	private bool _initialized;

	public void Initialize()
	{
	}

	public void Set(ResourceFlag resFlag, int season)
	{
	}

	private FlagItem InstantiateFlag(ResourceFlag resFlag, int season)
	{
		return null;
	}
}

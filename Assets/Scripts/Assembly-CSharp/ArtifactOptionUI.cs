using Awesomepiece.Model;
using UnityEngine;

public class ArtifactOptionUI : MonoBehaviour
{
	public enum Size
	{
		Big = 0,
		Normal = 1,
		Small = 2
	}

	public Size size;

	public ArtifactOptionLine[] optionLines;

	private ArtifactModel _artifact;

	private bool _hideMode;

	public void Init(ArtifactModel artifact)
	{
	}

	public void InitNext(ArtifactModel artifact)
	{
	}

	public void SetEmpty()
	{
	}

	public void SetHideMode(bool v)
	{
	}

	public void ShowStatPopup()
	{
	}
}

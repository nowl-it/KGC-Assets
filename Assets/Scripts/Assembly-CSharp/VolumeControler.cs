using UnityEngine;
using UnityEngine.UI;

public class VolumeControler : MonoBehaviour
{
	[ComponentConnect]
	public Slider bgmSlider;

	[ComponentConnect]
	public Slider fxSlider;

	[ComponentConnect]
	public Toggle bgmToggle;

	[ComponentConnect]
	public Toggle fxToggle;

	public void Show()
	{
	}

	public void OnSlideBgm()
	{
	}

	public void OnToggleBgm()
	{
	}

	public void OnSlideFx()
	{
	}

	public void OnToggleFx()
	{
	}
}

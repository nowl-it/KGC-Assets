using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class LocalizedImage : MonoBehaviour, ILocalizedComponent
{
	private Image _target;

	public string key;

	public void OnEnable()
	{
	}

	private void Reset()
	{
	}

	public void HandleLocalizerInitialized()
	{
	}
}

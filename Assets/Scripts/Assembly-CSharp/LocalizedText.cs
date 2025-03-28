using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class LocalizedText : MonoBehaviour, ILocalizedComponent
{
	private Text _target;

	public string key;

	public string format;

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

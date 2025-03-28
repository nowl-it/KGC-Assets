using UnityEngine;
using UnityEngine.Rendering;

public class ImageFont : ScriptableObject
{
	[SerializeField]
	private SerializedDictionary<int, Sprite> _asciiCharacterDict;

	[SerializeField]
	private float _padding;

	[SerializeField]
	private float _referenceHeight;

	private Sprite[] _characters;

	public float padding => 0f;

	public float referenceHeight => 0f;

	private void OnEnable()
	{
	}

	public Sprite GetCharacterSprite(int ascii)
	{
		return null;
	}
}

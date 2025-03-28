using UnityEngine;
using UnityEngine.UI;

public class SpriteFrameAnimation : MonoBehaviour
{
	public Sprite[] frames;

	public float frameTime;

	[GetComponent]
	public Image image;

	private void Update()
	{
	}
}

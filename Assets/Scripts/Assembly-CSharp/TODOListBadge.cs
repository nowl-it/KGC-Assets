using UnityEngine;
using UnityEngine.UI;

public class TODOListBadge : MonoBehaviour
{
	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Image _balloonImage;

	[SerializeField]
	private Sprite _defaultBalloon;

	[SerializeField]
	private Sprite _newBalloon;

	[SerializeField]
	private Sprite _megaPhoneBalloon;

	public void Reload()
	{
	}
}

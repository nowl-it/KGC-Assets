using UnityEngine;
using UnityEngine.UI;

public class TreasureGachaResultItem : MonoBehaviour
{
	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private Image _illustImage;

	[SerializeField]
	private Image _frameImage;

	[SerializeField]
	private Image[] _rarityColorImages;

	[SerializeField]
	private ParticleSystem[] _rarityColorParticles;

	public Animator animator => null;

	public void Set(ResourceTreasure resTreasure)
	{
	}

	public void SetAlpha(float a)
	{
	}
}

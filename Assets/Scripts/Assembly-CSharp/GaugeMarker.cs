using UnityEngine;

public class GaugeMarker : MonoBehaviour
{
	public GameUnit unit;

	public int markerSize;

	[SerializeField]
	private bool _fixedMarkerSize;

	public RectTransform markerTransform;

	public ConditionalImage markerSprite;

	private static float rogueLikeHpDmgValueRatio => 0f;

	private void Awake()
	{
	}

	public void Set(int value, int shieldValue, int maxValue)
	{
	}
}

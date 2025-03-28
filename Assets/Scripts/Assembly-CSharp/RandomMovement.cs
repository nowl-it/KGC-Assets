using UnityEngine;

public class RandomMovement : MonoBehaviour
{
	[SerializeField]
	private Vector2 _randomMoveRange;

	[SerializeField]
	private Vector2 _randomScalePerRange;

	[SerializeField]
	private Vector2 _moveSpeedMinMax;

	[SerializeField]
	private bool _scaleMovementValueByScale;

	private Vector2 _originPos;

	private Vector2 _originScale;

	private Vector2 _moveVec;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}

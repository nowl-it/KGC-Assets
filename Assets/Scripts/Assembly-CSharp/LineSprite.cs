using UnityEngine;

public class LineSprite : MonoBehaviour
{
	public SpriteRenderer spriteRenderer;

	public float lineWeight;

	public bool usingHeight;

	public float angleOffset;

	public bool scaleMatch;

	public ParticleSystem particle;

	public Transform startTransform;

	public Transform endTransform;

	private Vector3 _startOffset;

	private Vector3 _endOffset;

	private bool _useArrow;

	private bool _update;

	private float _particleEmissionRateOverTime;

	private bool _ground;

	private BattleManager _battleManager;

	private void Awake()
	{
	}

	public LineSprite Set(Vector3 start, Vector3 end, BattleManager battle, bool toWorld = true)
	{
		return null;
	}

	public LineSprite SetTransform(Transform start, Transform end, Vector3 startOffset, Vector3 endOffset, BattleManager battle, bool useArrow = false)
	{
		return null;
	}

	public void StopUpdate()
	{
	}

	public void Update()
	{
	}

	public LineSprite SetGround(bool v)
	{
		return null;
	}
}

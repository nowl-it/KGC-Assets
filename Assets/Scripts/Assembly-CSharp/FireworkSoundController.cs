using UnityEngine;

public class FireworkSoundController : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem _trailParticle;

	private int _particleCount;

	private const float GEN_INTERVAL = 0.1f;

	private float _timer;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}

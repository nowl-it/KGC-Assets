using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SimpleAudioSource : MonoBehaviour
{
	public AudioSource audioSource;

	public AudioClip audioClip;

	public void Set(AudioClip audioClip)
	{
	}

	public void Play(bool loop = false)
	{
	}

	public void Stop(bool destroy = true)
	{
	}

	public void Update()
	{
	}
}

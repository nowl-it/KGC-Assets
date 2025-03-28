using System;

[Serializable]
public class AudioItem
{
	[Serializable]
	public enum LoopMode
	{
		DoNotLoop = 0,
		LoopSubitem = 1,
		LoopSequence = 2,
		PlaySequenceAndLoopLast = 4,
		IntroLoopOutroSequence = 5
	}

	public string Name;

	public LoopMode Loop;

	public int loopSequenceCount;

	public float loopSequenceOverlap;

	public float loopSequenceRandomDelay;

	public float loopSequenceRandomPitch;

	public float loopSequenceRandomVolume;

	public bool DestroyOnLoad;

	public float Volume;

	public AudioPickSubItemMode SubItemPickMode;

	public float MinTimeBetweenPlayCalls;

	public int MaxInstanceCount;

	public float Delay;

	public float RandomVolume;

	public float RandomPitch;

	public float RandomDelay;

	public bool overrideAudioSourceSettings;

	public float audioSource_MinDistance;

	public float audioSource_MaxDistance;

	public float spatialBlend;

	public AudioSubItem[] subItems;

	internal int _lastChosen;

	internal double _lastPlayedTime;

	[NonSerialized]
	private AudioCategory _category;

	public AudioCategory category
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public AudioItem()
	{
	}

	public AudioItem(AudioItem orig)
	{
	}

	private void Awake()
	{
	}

	public void ResetSequence()
	{
	}

	internal void _Initialize(AudioCategory categ)
	{
	}

	private void _NormalizeSubItems()
	{
	}

	private static bool _IsValidSubItem(AudioSubItem item)
	{
		return false;
	}

	public void UnloadAudioClip()
	{
	}
}

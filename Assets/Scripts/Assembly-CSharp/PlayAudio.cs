public class PlayAudio : AudioTriggerBase
{
	public enum PlayPosition
	{
		Global = 0,
		ChildObject = 1,
		ObjectPosition = 2
	}

	public enum SoundType
	{
		SFX = 0,
		Music = 1,
		AmbienceSound = 2
	}

	public string audioID;

	public SoundType soundType;

	public PlayPosition position;

	public float volume;

	public float delay;

	public float startTime;

	protected override void Awake()
	{
	}

	private void _Play()
	{
	}

	protected override void _OnEventTriggered()
	{
	}

	private void _PlayMusic()
	{
	}

	private void _PlayAmbienceSound()
	{
	}
}

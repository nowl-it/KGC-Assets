public class PauseAllAudio : AudioTriggerBase
{
	public enum PauseType
	{
		All = 0,
		MusicOnly = 1,
		AmbienceOnly = 2,
		Category = 3
	}

	public PauseType pauseType;

	public float fadeOut;

	public string categoryName;

	protected override void _OnEventTriggered()
	{
	}
}

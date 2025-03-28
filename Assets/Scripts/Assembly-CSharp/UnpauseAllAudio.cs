public class UnpauseAllAudio : AudioTriggerBase
{
	public enum PauseType
	{
		All = 0,
		MusicOnly = 1,
		AmbienceOnly = 2,
		Category = 3
	}

	public PauseType pauseType;

	public float fadeIn;

	public string categoryName;

	protected override void _OnEventTriggered()
	{
	}
}

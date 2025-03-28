public class AudioFader
{
	private float _fadeOutTotalTime;

	private double _fadeOutStartTime;

	private float _fadeInTotalTime;

	private double _fadeInStartTime;

	public double time { get; set; }

	public bool isFadingOutComplete => false;

	public bool isFadingOut => false;

	public bool isFadingOutOrScheduled => false;

	public bool isFadingIn => false;

	public void Set0()
	{
	}

	public void FadeIn(float fadeInTime, bool stopCurrentFadeOut = false)
	{
	}

	public void FadeIn(float fadeInTime, double startToFadeTime, bool stopCurrentFadeOut = false)
	{
	}

	public void FadeOut(float fadeOutLength, float startToFadeTime)
	{
	}

	public float Get()
	{
		return 0f;
	}

	public float Get(out bool finishedFadeOut)
	{
		finishedFadeOut = default(bool);
		return 0f;
	}

	private float _GetFadeOutValue()
	{
		return 0f;
	}

	private float _GetFadeInValue()
	{
		return 0f;
	}

	private float _GetFadeValue(float t, float dt)
	{
		return 0f;
	}
}

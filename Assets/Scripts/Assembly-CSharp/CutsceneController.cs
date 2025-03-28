using UnityEngine;

public class CutsceneController : MonoBehaviour
{
	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private Camera _camera;

	private CutscenePlayer _player;

	private ResourceCutscene _resCutscene;

	private bool _waitForAnimationToPause;

	public void Show(CutscenePlayer player, Canvas canvas)
	{
	}

	public void Close()
	{
	}

	private void FixedUpdate()
	{
	}

	public void PauseAnimation()
	{
	}

	public void ResumeAnimation()
	{
	}

	public void TriggerNextScript()
	{
	}

	public void TriggerNextScriptAndPause()
	{
	}

	public bool CanMoveToNextStep()
	{
		return false;
	}

	public void PlayMusic(string paramStr)
	{
	}

	public void PlaySound(string key)
	{
	}

	public void ResetAnimation()
	{
	}
}

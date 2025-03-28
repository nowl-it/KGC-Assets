using UnityEngine;
using UnityEngine.UI;

public class PvPResultItem : MonoBehaviour
{
	public enum State
	{
		Waiting = 0,
		Current = 1,
		Win = 2,
		Lose = 3
	}

	public ConditionalRoot condRoot;

	public ProfileAvatar profileAvatar;

	public Text score;

	public Image mark;

	private ResourcePvpEnemyPreset _resPvpEnemyPreset;

	public int id => 0;

	public void Init(ResourcePvpEnemyPreset resPvpEnemyPreset)
	{
	}

	public void Set(State state)
	{
	}
}

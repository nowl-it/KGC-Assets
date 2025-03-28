using UnityEngine;
using UnityEngine.UI;

public class BarrackAltarItem : MonoBehaviour
{
	[ComponentConnect]
	public ConditionalImage godImage;

	[ComponentConnect]
	public Text levelText;

	[ComponentConnect("Flame_0~", true)]
	public Animator flame;

	private int _id;

	private int _level;

	public void Set(int id, int level)
	{
	}

	private void OnEnable()
	{
	}
}

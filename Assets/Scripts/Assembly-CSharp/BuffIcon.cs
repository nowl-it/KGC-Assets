using UnityEngine;
using UnityEngine.UI;

public class BuffIcon : MonoBehaviour
{
	public Buff.BuffType type;

	public Image background;

	public Image backgroundFill;

	public Image iconImage;

	public Image remainImage;

	public float angle;

	public void Set(BuffPanel panel, Buff.BuffType type, Sprite icon, float time, float maxTime, int effectType, float angle, float scale = 1f)
	{
	}
}

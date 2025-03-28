using UnityEngine;
using UnityEngine.UI;

public class BossSkillGauge : MonoBehaviour
{
	public Image emptyImage;

	public Image gaugeImage;

	public Image flashImage;

	public Image fullImage;

	public Image activeImage;

	private Image.FillMethod _fillMethod;

	public void Show(string imagePrefix, Image.FillMethod fillMethod = Image.FillMethod.Horizontal, float scale = 1f)
	{
	}

	private void Clear()
	{
	}

	public void SetStep(int step, int maxStep)
	{
	}
}

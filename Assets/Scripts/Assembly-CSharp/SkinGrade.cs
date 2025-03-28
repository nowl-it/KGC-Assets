using UnityEngine;
using UnityEngine.UI;

public class SkinGrade : MonoBehaviour
{
	private ResourceSkin _resSkin;

	public ConditionalImage skinGradeIconConditional;

	public Text skinGradeText;

	public ClickOutsideClose skinGradeDesc;

	public GameObject skinGradeDesc_Illust;

	public GameObject skinGradeDesc_Effect;

	public GameObject skinGradeDesc_Sound;

	public Graphic[] skinGradeDescGraphicsToApplyColor;

	public void Init(ResourceSkin skin)
	{
	}

	public void ShowDesc(bool show)
	{
	}
}

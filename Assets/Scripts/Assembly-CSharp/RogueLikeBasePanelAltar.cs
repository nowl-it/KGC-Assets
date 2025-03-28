using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeBasePanelAltar : MonoBehaviour
{
	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private AwesomeOutline _iconOutline;

	[SerializeField]
	private Text _levelText;

	private int _level;

	private Tweener[] _effectTweens;

	public void Set(int index, int level)
	{
	}
}

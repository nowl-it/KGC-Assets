using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfoPanel : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	[GetComponent]
	public CanvasGroup canvasGroup;

	[ComponentConnect]
	public Image iconImage;

	[ComponentConnect]
	public Text nameText;

	public ConditionalGroup frameImage;

	public Text tierText;

	public RectTransform tierBox;

	public List<Text> statTexts;

	public List<ConditionalTextColor> statTextColors;

	public List<Image> statImages;

	public List<GameObject> statBoxes;

	[GetComponent]
	public Border border;

	public GameObject enemyDesc;

	public ItemInfoOptionBox[] options;

	public bool showOptionEffect;

	public LayoutFitter fitter;

	[GetComponent]
	[SerializeField]
	private ClickOutsideClose _clickOutsideClose;

	private Item _item;

	public ClickOutsideClose clickOutsideClose => null;

	public void Show(Item item, Vector2 pos, Vector3 rectTransformOffset = default(Vector3), bool fade = true, GameUnit target = null, bool controlFontSize = true)
	{
	}

	public void Show(Item item, bool fade = false, GameUnit target = null, bool controlFontSize = true, bool showEmpty = false)
	{
	}

	public void SetEnemyDesc(bool v)
	{
	}

	public void Hide()
	{
	}

	public float GetValueWithItemAdaptability(GameUnit target, float value)
	{
		return 0f;
	}

	public float GetValueWithAdvancedItemAdaptability(GameUnit target, float value)
	{
		return 0f;
	}

	public void SetClickOutsideClose(List<Transform> excepts, Action onClose)
	{
	}
}

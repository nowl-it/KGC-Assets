using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class GachaResultItem : MonoBehaviour
{
	public Image bg;

	public CanvasGroup textBox;

	public Image unitImage;

	public Image newUnitImage;

	public Image goldImage;

	public Image expBookImage;

	public Image goldImageIcon;

	public Image cashImage;

	public Image frameImage;

	public Image soulItemImage;

	public Image inventoryItemImage;

	public GameObject artifactObj;

	public Image artifactImage;

	public Image artifactFrame;

	public GameObject valueBox;

	public Text valueText;

	public Text typeText;

	public Image newTextImage;

	public UnitSoulItem unitSoulItem;

	public GameObject dismantleObj;

	public Text dismantleAmountText;

	public GameObject dismantleSelectedObj;

	public GameObject highlightObj;

	[NonSerialized]
	public int dismantleCount;

	[NonSerialized]
	public ResourceArtifact resArtifact;

	private int _ownCount;

	public bool isDismantleMax => false;

	public void Set(GachaResult gachaResult)
	{
	}

	public void ShowDismantleObj(bool show)
	{
	}

	public void OnClick()
	{
	}

	public void OnClickAddDismantleAmount(int amount)
	{
	}

	public void SetDismantleAmount(int amount, bool max = false)
	{
	}

	public void OnClickDismantleSelect()
	{
	}

	public void ShowDismantleHighlight(bool show)
	{
	}
}

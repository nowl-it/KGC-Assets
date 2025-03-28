using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuffPanel : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	[GetComponent]
	public GridLayoutGroup gridLayoutGroup;

	public GameObject buffPrefab;

	private List<BuffIcon> _buffs;

	public void Awake()
	{
	}

	public void AddBuff(int team, Buff buff)
	{
	}

	public void AddBuff(int team, Buff.BuffType type, Sprite icon, float time, float maxTime = -1f, bool overlap = false, bool infinite = false, Item item = null)
	{
	}

	public void RemoveBuff(Sprite icon)
	{
	}

	public void Clear()
	{
	}

	public void SetViewMode(bool set)
	{
	}

	public void EquipEffect()
	{
	}
}

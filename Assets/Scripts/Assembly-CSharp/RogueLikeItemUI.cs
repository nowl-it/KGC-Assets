using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeItemUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFitAfterFrame_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RogueLikeItemUI _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CFitAfterFrame_003Ed__21(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Text _tierText;

	[SerializeField]
	private Text _itemTypeText;

	[SerializeField]
	private RogueLikeItemIcon _icon;

	[SerializeField]
	private StatDisplayer _statDisplayer;

	[SerializeField]
	private GameObject _statPartition;

	[SerializeField]
	private UnitSkillDisplayer _skillDisplayer;

	[SerializeField]
	private Text _itemDescLong;

	[SerializeField]
	private Text[] _itemDescs;

	[SerializeField]
	private GameObject _itemOwnCountsGroup;

	[SerializeField]
	private Text[] _itemOwnCountTexts;

	[SerializeField]
	private Border _border;

	[SerializeField]
	private LayoutFitter _layoutFitter;

	[SerializeField]
	private Border _itemDescBGBorder;

	[SerializeField]
	private TextFitter _itemDescLongTextFitter;

	[SerializeField]
	private LayoutFitter _itemDescsLayoutFitter;

	[SerializeField]
	private ConditionalBase _selectedConditionals;

	private float _itemDescLongOriginHeight;

	public void Set(Constants.RogueLikeItemType type, int tier, int id, int amount)
	{
	}

	public void Clear(int tier)
	{
	}

	private void Fit()
	{
	}

	[IteratorStateMachine(typeof(_003CFitAfterFrame_003Ed__21))]
	private IEnumerator FitAfterFrame()
	{
		return null;
	}

	private void FitImpl()
	{
	}

	public void SetEquip(Item item, bool own)
	{
	}

	public void SetRune(Rune rune, bool own)
	{
	}

	public void SetItem(ResourceItem resItem, int amount = 1)
	{
	}

	public void SetArtifact(RogueLikeArtifactModel artifact, bool showBuildingAtIcon)
	{
	}

	public void SetHero(ResourceUnit resUnit, int level, bool own, bool showSpeed)
	{
	}

	private void SetGold(int tier, int amount)
	{
	}

	private void SetHeroCustomDesc(int unitId, string desc)
	{
	}

	public void SetCustom(Sprite icon, int tier, string title, string desc)
	{
	}

	public void SetSelected(int state)
	{
	}

	public void SetEquipped(GameUnit by)
	{
	}

	private int[] GetItemOwnCounts(ResourceItem resItem)
	{
		return null;
	}
}

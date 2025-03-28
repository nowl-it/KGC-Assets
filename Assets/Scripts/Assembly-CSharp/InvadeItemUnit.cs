using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class InvadeItemUnit : ItemUnitBase
{
	[CompilerGenerated]
	private sealed class _003CIdleSequenceCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InvadeItemUnit _003C_003E4__this;

		private float _003Cv_003E5__2;

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
		public _003CIdleSequenceCoroutine_003Ed__14(int _003C_003E1__state)
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
	private ConditionalGroup _invadeItemTierConditionals;

	[SerializeField]
	private ConditionalGroup _bossConditionals;

	[SerializeField]
	private SpriteRenderer[] _unitSprites;

	[SerializeField]
	private GameObject _inventoryObject;

	[SerializeField]
	private GameObject _usedObject;

	[SerializeField]
	private SpriteRenderer[] _themeColorSprites;

	[SerializeField]
	private SpriteRenderer _flameBackSprite;

	[SerializeField]
	private SpriteMask _flameBackSpriteMask;

	[SerializeField]
	private SortingGroup _sortingGroup;

	public bool isUsed;

	public InvadeItem invadeItem;

	public void Init(int id, int battleManagerIdx, bool isUsed = false)
	{
	}

	public void Init(ResourceColosseumInvadeItem resInvadeItem, int battleManagerIdx, bool isUsed = false)
	{
	}

	private void LateUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CIdleSequenceCoroutine_003Ed__14))]
	protected override IEnumerator IdleSequenceCoroutine()
	{
		return null;
	}

	public void OnUsed()
	{
	}

	public override void OnClick()
	{
	}

	public override void SetSpriteOrder(int order)
	{
	}
}

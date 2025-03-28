using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LevelSyncSelectedUnitPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CArrowRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelSyncSelectedUnitPanel _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CArrowRoutine_003Ed__13(int _003C_003E1__state)
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
	private ConditionalGroup _unitSelectedConditional;

	[SerializeField]
	private LevelSyncedUnitInfo _syncedUnitInfo;

	[SerializeField]
	private UnitStatBox _unitStatBox;

	[SerializeField]
	private Text _levelSyncDesc;

	[SerializeField]
	private Text _unitName;

	[SerializeField]
	private Text _unitSubName;

	[SerializeField]
	private UnitIllust _illust;

	[SerializeField]
	private Transform _arrowObj;

	[SerializeField]
	private int _arrowTweenSpeed;

	private Coroutine _arrowRoutine;

	public DraggableCardBase<CardData> slot => null;

	public void Set(CardData cardData, int nextLevel, int nextPotential, IDraggableCardBaseHandler<CardData> handler)
	{
	}

	[IteratorStateMachine(typeof(_003CArrowRoutine_003Ed__13))]
	private IEnumerator ArrowRoutine()
	{
		return null;
	}

	private void OnDisable()
	{
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class UnitMaxLevelEffectPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCloseRoutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnitMaxLevelEffectPanel _003C_003E4__this;

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
		public _003CCloseRoutine_003Ed__9(int _003C_003E1__state)
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

	[CanBeNull]
	[SerializeField]
	private RectTransform _illustsRoot;

	[SerializeField]
	private List<Image> _illustImages;

	private GameUnit _gameUnit;

	private bool _skinAvailable;

	private Coroutine _closeRoutine;

	public void Show(GameUnit unit)
	{
	}

	private void SetSprite()
	{
	}

	public static bool CheckAprilFools(GameUnit gameUnit)
	{
		return false;
	}

	private bool CheckAndSetAprilFools()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CCloseRoutine_003Ed__9))]
	private IEnumerator CloseRoutine()
	{
		return null;
	}

	public void ForceClose()
	{
	}
}

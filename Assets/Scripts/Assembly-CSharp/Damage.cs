using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class Damage : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayAnimCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Damage _003C_003E4__this;

		private float _003Cfirst_003E5__2;

		private float _003Csecond_003E5__3;

		private float _003Ctimer_003E5__4;

		private float _003CscaleMoveTime_003E5__5;

		private float _003CprevY_003E5__6;

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
		public _003CPlayAnimCoroutine_003Ed__13(int _003C_003E1__state)
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

	private Vector2 _origin;

	private readonly List<SpriteRenderer> _numbers;

	private Sequence _sequence;

	public bool isCritical;

	private float _scale;

	public int chainCount;

	private void Awake()
	{
	}

	private void Init(Vector2 pos)
	{
	}

	private void ClearNumbers()
	{
	}

	public void SetNonNumericValue(Vector2 pos, int value, bool enemy = true)
	{
	}

	public void Set(Vector2 pos, DamageShootData damageShootData, bool enemyTarget = true)
	{
	}

	public Damage ChainTo(Damage parent)
	{
		return null;
	}

	private void Play()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayAnimCoroutine_003Ed__13))]
	private IEnumerator PlayAnimCoroutine()
	{
		return null;
	}

	private void SetNumbersAlpha(float alpha)
	{
	}

	private void MakeNumber(float x, float y, int number, int index, DamageSprite damageSprite, bool enemyTarget = true, DamageShootData damageShootData = default(DamageShootData))
	{
	}

	private void DestroySelf()
	{
	}
}

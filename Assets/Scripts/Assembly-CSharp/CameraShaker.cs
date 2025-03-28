using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CameraShaker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCameraShaking_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CameraShaker _003C_003E4__this;

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
		public _003CCameraShaking_003Ed__19(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CStopShaking_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CameraShaker _003C_003E4__this;

		public float time;

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
		public _003CStopShaking_003Ed__20(int _003C_003E1__state)
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

	private Camera _camera;

	private Transform _cameraTransform;

	private Vector3 _cameraPos;

	private bool _isShaking;

	private Vector3 _shakeVector;

	private Vector3 _lastShakeVector;

	private Vector3 _shakeVectorSum;

	private Coroutine _shakeCoroutine;

	private float _startTime;

	private float _originSize;

	[SerializeField]
	private float _shakeAmountX;

	[SerializeField]
	private float _shakeAmountY;

	[SerializeField]
	private float _shakeAmountSize;

	[SerializeField]
	private float _shakeTime;

	[SerializeField]
	private float _shakeInterval;

	[SerializeField]
	private bool _shakeTwoDirection;

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void StartShaking(BattleManager battle, float shakeAmountX, float shakeAmountY, float shakeAmountSize, float shakeTime, float shakeInterval, bool shakeTwoDirection)
	{
	}

	[IteratorStateMachine(typeof(_003CCameraShaking_003Ed__19))]
	private IEnumerator CameraShaking()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStopShaking_003Ed__20))]
	private IEnumerator StopShaking(float time)
	{
		return null;
	}
}

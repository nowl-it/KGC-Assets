using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class KingGakReturnEventPanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003CUnitSelectCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KingGakReturnEventPanel _003C_003E4__this;

		private int _003CstopIndex_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CUnitSelectCoroutine_003Ed__23(int _003C_003E1__state)
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
	private DialogBox _dialogBox;

	[SerializeField]
	private GameObject _dialogRoot;

	[SerializeField]
	private Image _illustImage;

	[SerializeField]
	private GameObject _shieldRoot;

	[SerializeField]
	private GameObject _shieldObject;

	[SerializeField]
	private Image _shieldScreenMask;

	[SerializeField]
	private GameObject _shieldArrowObject;

	[SerializeField]
	private Text _pleaseRotateShieldText;

	[SerializeField]
	private GameObject _unitSummonRoot;

	[SerializeField]
	private RectTransform _unitIconsRoot;

	[SerializeField]
	private GameObject _unitIconPrefab;

	[SerializeField]
	private Image _selectedUnitIconBG;

	private int _phase;

	private int _rewardUnitId;

	private int _rewardUnitIconindex;

	private readonly List<GameObject> _unitIcons;

	private float _touchStartRotOffset;

	private Vector2 _shieldRotAxis;

	private bool _canClose;

	public void Awake()
	{
	}

	public void Show()
	{
	}

	private void Update()
	{
	}

	private void ToNextPhase()
	{
	}

	[IteratorStateMachine(typeof(_003CUnitSelectCoroutine_003Ed__23))]
	private IEnumerator UnitSelectCoroutine()
	{
		return null;
	}

	private void ShowRoot(GameObject root)
	{
	}

	private void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}

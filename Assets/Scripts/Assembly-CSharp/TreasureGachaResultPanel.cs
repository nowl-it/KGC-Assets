using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class TreasureGachaResultPanel : PopupPanel
{
	[Serializable]
	private class HoldedData
	{
		public int resGachaId;

		public int gachaCount;

		public int[] results;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public TreasureGachaResultPanel _003C_003E4__this;

		public Animator capTarget;

		internal bool _003CGachaResultEffect_003Eb__2()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGachaEffect_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TreasureGachaResultPanel _003C_003E4__this;

		private Animator _003Ctarget_003E5__2;

		private WaitForSeconds _003CwaitSpecial_003E5__3;

		private List<TreasureModel>.Enumerator _003C_003E7__wrap3;

		private bool _003CprevSkip_003E5__5;

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
		public _003CGachaEffect_003Ed__49(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CGachaResultEffect_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TreasureGachaResultPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass48_0 _003C_003E8__1;

		private Animator _003Ctarget_003E5__2;

		private bool _003CcontainsSpecial_003E5__3;

		private bool _003CcontainsRare_003E5__4;

		private int _003CslidePhase_003E5__5;

		private int _003CmaxSlidePhase_003E5__6;

		private float _003CprevMouseY_003E5__7;

		private WaitForSeconds _003CnextDefaultCardTime_003E5__8;

		private WaitForSeconds _003CnextSpecialCardTime_003E5__9;

		private int _003Ci_003E5__10;

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
		public _003CGachaResultEffect_003Ed__48(int _003C_003E1__state)
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
	private Button _skipButton;

	[SerializeField]
	[Header("Start")]
	private Animator _startAnimator;

	[SerializeField]
	private RectTransform _swordObj;

	[SerializeField]
	private GameObject[] _gachaCountStars;

	[SerializeField]
	private GameObject[] _gachaCountSpecialStars;

	[Header("Middle")]
	[SerializeField]
	private Animator _middleAnimator;

	[SerializeField]
	private Image[] _roleIcon;

	[SerializeField]
	private Image[] _roleColoredImages;

	[SerializeField]
	private Image[] _treasureIllusts;

	[SerializeField]
	private Image[] _treasureBGIllusts;

	[SerializeField]
	private Image _treasureCardIllust;

	[SerializeField]
	private Image _treasureCardIllustFrame;

	[SerializeField]
	private Text _treasureDescText;

	[SerializeField]
	private Text _treasureRarityText;

	[SerializeField]
	private Text[] _treasureNameText;

	[SerializeField]
	private Image _backgroundImage;

	[SerializeField]
	[Header("End")]
	private GameObject _endObject;

	[SerializeField]
	private TreasureGachaResultItem[] _endResultItems;

	[SerializeField]
	private BuyGachaButtonGroup _buyGachaButtonGroup;

	[Header("Anim Settings")]
	private int _gachaCount;

	[SerializeField]
	private float[] _slideValues;

	[SerializeField]
	private float _currentSlideValue;

	[SerializeField]
	private float[] _slideMultipleAdjustValues;

	[SerializeField]
	private int[] _slideTierChangeIndices;

	[Space(5f)]
	[SerializeField]
	private float _swordUpTime;

	[SerializeField]
	private float _specialIntroTime;

	[SerializeField]
	private float _nextResultTimeSpecial;

	[SerializeField]
	[Space(5f)]
	private float _nextCardTime;

	[SerializeField]
	private float _nextCardTimeSpecial;

	[SerializeField]
	private float _toIdleDelayTime;

	private List<TreasureModel> _results;

	[SerializeField]
	private Vector2 _swordStartPos;

	private ResourceGacha _resGacha;

	private bool _skip;

	private bool _deactiveSkipButtonOnSkip;

	private bool _isLoading;

	private bool _showBuyAnimation;

	private Coroutine _currentCoroutine;

	private List<AudioObject> _currentlyPlayingSounds;

	private AudioObject _swordSlidePhaseSound;

	private AudioObject _cardAppearSound;

	private Action _onComplete;

	private bool _canClose;

	[Obsolete]
	public override void Show()
	{
	}

	public void Show(ResourceGacha resGacha, int gachaCount, List<TreasureModel> results)
	{
	}

	public void ShowFromHoldedData()
	{
	}

	public void ShowBuyAnimation(List<int> treasureIds, Action onComplete = null)
	{
	}

	[IteratorStateMachine(typeof(_003CGachaResultEffect_003Ed__48))]
	private IEnumerator GachaResultEffect()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGachaEffect_003Ed__49))]
	private IEnumerator GachaEffect()
	{
		return null;
	}

	private void SetLoading(bool set)
	{
	}

	public new void OnClickClose()
	{
	}

	public void OnClickSkip()
	{
	}

	public AudioObject PlaySound(string key)
	{
		return null;
	}

	public void StopAllSounds()
	{
	}

	public void PlayStarSound(int index)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public override bool Close()
	{
		return false;
	}
}

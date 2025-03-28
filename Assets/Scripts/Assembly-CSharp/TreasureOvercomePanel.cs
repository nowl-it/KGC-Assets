using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class TreasureOvercomePanel : PopupPanel
{
	[Serializable]
	public class OvercomeInformationPanel
	{
		public ClickOutsideClose gameObject;

		public Text skillNameText;

		public RectTransform overcomeDescTextsRoot;

		public ImageTextPair overcomeDescTextPrefab;

		public List<Image> overcomeIcons;

		[NonSerialized]
		public List<ImageTextPair> treasureOvercomeDescTexts;

		public Text overcomeText;

		public GameObject activatedObj;

		public Button prevButton;

		public Button nextButton;
	}

	[Serializable]
	public class TreasureOvercomeMaterialPanel
	{
		public GameObject gameObject;

		public TreasureUIItem materialItemPrefab;

		public UIGridView materialsRoot;

		public ScrollRect usedMaterialScroll;

		public RectTransform usedMaterialRoot;

		public LayoutFitter usedMaterialsLayoutFitter;

		[NonSerialized]
		public List<TreasureUIItem> usedMaterialItems;

		[NonSerialized]
		public TreasureUIItem usedMaterialInventoryItem;

		public Text noneSelectedText;

		public GameObject selectAmountPanel;

		public Text[] addAmountTexts;

		public Text curAmountText;

		public ConditionalGroup confirmButton;

		[NonSerialized]
		public int materialItemCount;

		[NonSerialized]
		public int addedOvercome;

		public int materialInventoryCount => 0;

		public void AddUsedMaterial(TreasureUIItem treasure, Func<TreasureUIItem, IEnumerator> action, (int addMaterialAmount, int needMaterialItemCount) inventoryInfo = default((int addMaterialAmount, int needMaterialItemCount)))
		{
		}
	}

	[Serializable]
	public class OvercomePanel
	{
		public GameObject gameObject;

		public List<Image> overcomeIcons;

		public List<Animator> overcomeEffectAnimators;

		public Text maxLevelText;

		public TreasureUIItem overcomeMaterialItemPrefab;

		public RectTransform overcomeDescTextsRoot;

		public ImageTextPair overcomeDescTextPrefab;

		public LayoutFitter overcomeMaterialItemsRoot;

		[NonSerialized]
		public List<TreasureUIItem> overcomeMaterialItems;

		[NonSerialized]
		public List<ImageTextPair> treasureOvercomeDescTexts;

		public Button clearButton;

		public ConditionalGroup overcomeButton;

		public ConditionalImage overcomeButtonSpriteCond;
	}

	[Serializable]
	public class OvercomeAnimationPanel
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public TreasureModel treasure;

			public OvercomeAnimationPanel _003C_003E4__this;

			internal void _003CAnimationRoutine_003Eb__0(Image illust)
			{
			}

			internal void _003CAnimationRoutine_003Eb__1(Image illustBG)
			{
			}

			internal bool _003CAnimationRoutine_003Eb__2()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CAnimationRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TreasureModel treasure;

			public OvercomeAnimationPanel _003C_003E4__this;

			private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

			public int prevOvercome;

			private Sprite[] _003CovercomeSprites_003E5__2;

			private WaitForSeconds _003Cwait_003E5__3;

			private int _003Ci_003E5__4;

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
			public _003CAnimationRoutine_003Ed__14(int _003C_003E1__state)
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
		private Animator _overcomeAnimator;

		[SerializeField]
		private Text _treasureNameText;

		[SerializeField]
		private Text _treasureRarityText;

		[SerializeField]
		private Image[] _treasureIllust;

		[SerializeField]
		private Image[] _treasureIllustBG;

		[SerializeField]
		private Image _treasureCardIllust;

		[SerializeField]
		private Image _treasureFrame;

		[SerializeField]
		private Image _treasureRoleIcon;

		[SerializeField]
		private Animator[] _overcomeAnimStars;

		[SerializeField]
		private Image[] _overcomeAnimStarImages;

		[SerializeField]
		private ParticleSystem[] _overcomeAnimStarParticles;

		[SerializeField]
		private GameObject _overcomeAnimStarsRoot;

		private Coroutine _animationRoutine;

		public void Set(TreasureModel treasure, int prevOvercome)
		{
		}

		[IteratorStateMachine(typeof(_003CAnimationRoutine_003Ed__14))]
		private IEnumerator AnimationRoutine(TreasureModel treasure, int prevOvercome)
		{
			return null;
		}

		public bool IsActive()
		{
			return false;
		}
	}

	private struct OvercomeCostInfo
	{
		public int materialItemCount;

		public List<TreasureModel> materialTreasures;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COnClickOvercome_003Ed__64 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public TreasureOvercomePanel _003C_003E4__this;

		private int _003CprevOvercome_003E5__2;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

		private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Text _subNameText;

	[SerializeField]
	private GameObject _roleObj;

	[SerializeField]
	private Image _roleIcon;

	[SerializeField]
	private List<Animator> _overcomeEffectAnimators;

	[SerializeField]
	private List<Image> _overcomeIcons;

	[SerializeField]
	private ClickOutsideClose _overcomeTooltip;

	[SerializeField]
	private TextFitter _overcomeTooltipTextFitter;

	[SerializeField]
	private Border _overcomeTooltipBorder;

	[SerializeField]
	private UIFitter[] _overcomeTooltipFitters;

	[SerializeField]
	[Space(20f)]
	private List<TreasureOvercomePatternUI> _overcomePatternUIs;

	[SerializeField]
	private Image _overcomeStarSelectedImage;

	[SerializeField]
	private Transform[] _backgroundMovableTransforms;

	[SerializeField]
	[Space(20f)]
	private OvercomeInformationPanel _overcomeInformationPanel;

	[FormerlySerializedAs("_overcomeButton")]
	[SerializeField]
	private ConditionalGroup _mainButton;

	[SerializeField]
	private Button _overcomeAreaButton;

	[SerializeField]
	[Space(20f)]
	private TreasureOvercomeMaterialPanel _treasureOvercomeMaterialPanel;

	[SerializeField]
	private Button _materialAreaButton;

	[SerializeField]
	[Space(20f)]
	private OvercomePanel _overcomePanel;

	[Space(20f)]
	[SerializeField]
	private RectTransform _movableObject;

	[SerializeField]
	private ParticleSystem[] _cloudParticles;

	[Space(20f)]
	[SerializeField]
	private OvercomeAnimationPanel _overcomeAnimationPanel;

	private TreasureModel _treasure;

	private int _currentFocusedOvercomeIdx;

	private float _openTime;

	private AudioObject _ambienceSound;

	private int _clickCount;

	private bool _materialCountSettingEnd;

	private OvercomeCostInfo _overcomeCostInfo;

	private bool _requestProcessing;

	private float _originalCanvasScale;

	private bool _isDragging;

	private Vector2 _prevMousePosition;

	private bool _dragEndedAtThisFrame;

	private float _originalCameraSize;

	private float _zoomScale;

	private float _zoomMin;

	private float _zoomMax;

	private bool[] _isMovingAtLookAtTargetPos;

	private float _lookAtMoveSpeed;

	private Vector2 _lookAtTargetPos;

	private Tween _cameraMoveTween;

	private Tween _cameraScaleTween;

	private Vector2 _cameraPosition;

	private Vector3[] _backgroundMovableTransformsOriginPos;

	private Image[] _cloudImages;

	public const float START_BLOCK_INTERACTABLE_TIME = 1f;

	private TreasureOvercomePatternUI _curOvercomePatternUI => null;

	public Image overcomeStarSelectedImage => null;

	public OvercomeInformationPanel overcomeInformationPanel => null;

	public Button overcomeAreaButton => null;

	public TreasureOvercomeMaterialPanel materialPanel => null;

	public Button materialAreaButton => null;

	public float openTime => 0f;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Show(TreasureModel treasure)
	{
	}

	private void InactiveBackgroundPopups(bool set)
	{
	}

	private void Reload()
	{
	}

	public void NextOvercomeInformation(int idx)
	{
	}

	public bool ShowOvercomeInformation(int idx)
	{
		return false;
	}

	public void OnClickMainButton()
	{
	}

	private void ReloadOvercomeMaterialPanel()
	{
	}

	private void SetMaterialItem(int idx, GameObject go, List<TreasureModel> materials, InventoryItem materialItem, int needMaterialItemCount, Func<TreasureUIItem, IEnumerator> onClickMaterial)
	{
	}

	public void OvercomeMaterialItemAddAmount(int idx)
	{
	}

	public void OvercomeMaterialCountSettingEnd()
	{
	}

	public void CloseSelectMaterial(bool confirm)
	{
	}

	private void ClearMaterialPanelUsedMaterial()
	{
	}

	public void ShowTreasureOvercomePanel()
	{
	}

	[AsyncStateMachine(typeof(_003COnClickOvercome_003Ed__64))]
	public void OnClickOvercome()
	{
	}

	public void CloseOvercomePanel()
	{
	}

	public void ClearOvercomePanel()
	{
	}

	public override bool Close()
	{
		return false;
	}

	private void ReloadOvercomeIcon()
	{
	}

	private void Update()
	{
	}

	private void KillCameraMoveTween()
	{
	}

	private void KillCameraScaleTween()
	{
	}

	private void StartDrag()
	{
	}

	private void OnDragging()
	{
	}

	private Vector2 ClampPointToMapSize(Vector2 newPos, float zoomScale)
	{
		return default(Vector2);
	}

	public void EndDrag()
	{
	}

	public void LookAt(Vector2 position, float speed, float scale)
	{
	}

	public void SetZoomScale(float scale, float time)
	{
	}

	public float GetZoomedRatio()
	{
		return 0f;
	}

	private void SetCameraPosition(Vector2 pos)
	{
	}

	private void ShowOvercomeAnimation(int prevOvercome)
	{
	}

	public void ShowOvercomeTooltip()
	{
	}

	public void DisableAnimator()
	{
	}
}

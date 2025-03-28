using SRDebugger.Services;
using SRDebugger.UI.Controls;
using SRF;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		public const float NonFocusOpacity = 0.65f;

		private bool _isDirty;

		private bool _isDragging;

		private int _pointersOver;

		[RequiredField]
		public GameObject BottomHandle;

		[RequiredField]
		public CanvasGroup CanvasGroup;

		[RequiredField]
		public ConsoleLogControl Console;

		[RequiredField]
		public GameObject Dropdown;

		[RequiredField]
		public Image DropdownToggleSprite;

		[RequiredField]
		public Text TextErrors;

		[RequiredField]
		public Text TextInfo;

		[RequiredField]
		public Text TextWarnings;

		[RequiredField]
		public Toggle ToggleErrors;

		[RequiredField]
		public Toggle ToggleInfo;

		[RequiredField]
		public Toggle ToggleWarnings;

		[RequiredField]
		public GameObject TopBar;

		[RequiredField]
		public GameObject TopHandle;

		public bool IsVisible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void Update()
		{
		}

		private void ConsoleOnUpdated(IConsoleService console)
		{
		}

		public void SetDropdownVisibility(bool visible)
		{
		}

		public void SetAlignmentMode(ConsoleAlignment alignment)
		{
		}

		private void Refresh()
		{
		}

		private void RefreshAlpha()
		{
		}

		public void ToggleDropdownVisible()
		{
		}

		public void MenuButtonPressed()
		{
		}

		public void ClearButtonPressed()
		{
		}

		public void TogglesUpdated()
		{
		}

		public void OnPointerEnter(PointerEventData e)
		{
		}

		public void OnPointerExit(PointerEventData e)
		{
		}

		public void OnBeginDrag()
		{
		}

		public void OnEndDrag()
		{
		}
	}
}

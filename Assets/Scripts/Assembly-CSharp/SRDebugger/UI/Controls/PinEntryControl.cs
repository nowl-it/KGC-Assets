using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	public class PinEntryControl : SRMonoBehaviourEx
	{
		private bool _isVisible;

		private List<int> _numbers;

		[RequiredField]
		public Image Background;

		public bool CanCancel;

		[RequiredField]
		public Button CancelButton;

		[RequiredField]
		public Text CancelButtonText;

		[RequiredField]
		public CanvasGroup CanvasGroup;

		[RequiredField]
		public Animator DotAnimator;

		public Button[] NumberButtons;

		public Toggle[] NumberDots;

		[RequiredField]
		public Text PromptText;

		public event PinEntryControlCallback Complete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void Update()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void Clear()
		{
		}

		public void PlayInvalidCodeAnimation()
		{
		}

		protected void OnComplete()
		{
		}

		protected void OnCancel()
		{
		}

		private void CancelButtonPressed()
		{
		}

		public void PushNumber(int number)
		{
		}

		private void RefreshState()
		{
		}
	}
}

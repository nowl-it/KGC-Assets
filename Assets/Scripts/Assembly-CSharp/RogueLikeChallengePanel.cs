using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeChallengePanel : MonoBehaviour, IClosable
{
	[CompilerGenerated]
	private sealed class _003COpenAfterFrame_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RogueLikeChallengePanel _003C_003E4__this;

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
		public _003COpenAfterFrame_003Ed__14(int _003C_003E1__state)
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
	private List<RogueLikeChallengePanelItem> _items;

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private RectTransform _itemsRoot;

	[SerializeField]
	private GameObject _selectedCursor;

	[SerializeField]
	private Image[] _selectedCursorImages;

	[SerializeField]
	private GameObject _easyDescPanel;

	[SerializeField]
	private GameObject _normalDescPanel;

	[SerializeField]
	private GameObject _hardDescPanel;

	[SerializeField]
	private Text _levelText;

	[SerializeField]
	private Text _additionalScoreText;

	[SerializeField]
	private Text _additionalRewardText;

	[SerializeField]
	private Button _upButton;

	[SerializeField]
	private Button _downButton;

	public void Show()
	{
	}

	[IteratorStateMachine(typeof(_003COpenAfterFrame_003Ed__14))]
	private IEnumerator OpenAfterFrame()
	{
		return null;
	}

	private void SetLevel(int level)
	{
	}

	public void OnClickLevelButton(int levelDelta)
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}

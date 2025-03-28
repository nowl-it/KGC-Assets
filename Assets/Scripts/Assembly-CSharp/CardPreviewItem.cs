using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class CardPreviewItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStatusTextAnim_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CardPreviewItem _003C_003E4__this;

		private int _003Cidx_003E5__2;

		private WaitForSeconds _003Csecond_003E5__3;

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
		public _003CStatusTextAnim_003Ed__22(int _003C_003E1__state)
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

	public Image unitSprite;

	public GameObject border;

	public GameObject[] levelBox;

	public Text levelText;

	public Text mercenaryText;

	public ArtifactEffectIcon[] artifactEffectIcons;

	public Image potentialIcon;

	public ConditionalGroup potentialTierConditionals;

	public ConditionalGroup statusBoxConditionalGroup;

	public Text statusText;

	[SerializeField]
	private TreasureUIItem _treasureItem;

	public ConditionalGroup condGrayScaleGroup;

	private int _cardId;

	private string[] options;

	private Coroutine _coroutine;

	private List<string> _statusTexts;

	public void Set(CardData cardData)
	{
	}

	public void Set(int cardId, int level, int potentialTier, int potential = -1, bool useSyncedLevelColor = false, bool multiplyTextColor = false, TreasureModel treasure = null)
	{
	}

	public void SetExp(int cardId, int exp)
	{
	}

	public void SetMercenray(bool set)
	{
	}

	public void ReloadArtifactEffects(int idx, List<ArtifactModel> artifacts)
	{
	}

	public void AddStatus(string text, bool grayScale)
	{
	}

	[IteratorStateMachine(typeof(_003CStatusTextAnim_003Ed__22))]
	private IEnumerator StatusTextAnim()
	{
		return null;
	}
}

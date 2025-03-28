using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PvPScoreResultPanel : MonoBehaviour
{
	public class TierData
	{
		public int tier;

		public string name;

		public Sprite tierIcon;

		public Sprite starIcon;

		public TierData(IResourceRankTier resTier)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRepresent_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PvPScoreResultPanel _003C_003E4__this;

		private Color _003Ccolor_003E5__2;

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
		public _003CRepresent_003Ed__16(int _003C_003E1__state)
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
	private LerpText _rankScoreText;

	[SerializeField]
	private Text _rankScoreDeltaText;

	[SerializeField]
	private Text _tierNameText;

	[SerializeField]
	private Image _tierNameTextEffect;

	[SerializeField]
	private Image _tierIconImage;

	[SerializeField]
	private Image _tierIconEffect;

	[SerializeField]
	private Image _starIconImage;

	[SerializeField]
	private Image _starIconEffect;

	[SerializeField]
	private ConditionalGroup _winConditionals;

	private TierData _prevTierData;

	private TierData _curTierData;

	private int _rankScore;

	private int _addedRankScore;

	private bool _isWin;

	public void Init(int rankScore, int addedRankScore, bool isWin, TierData prevTierData, TierData curTierData)
	{
	}

	[IteratorStateMachine(typeof(_003CRepresent_003Ed__16))]
	public IEnumerator Represent()
	{
		return null;
	}
}

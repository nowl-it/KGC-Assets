using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Awesomepiece.Model;
using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.UI;

public class ClanGameOverPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public int bossHp;

		internal string _003CReload_003Eb__1(long hp)
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass17_1
	{
		public UIEffect uiEffect;

		internal float _003CReload_003Eb__2()
		{
			return 0f;
		}

		internal void _003CReload_003Eb__3(float v)
		{
		}

		internal float _003CReload_003Eb__4()
		{
			return 0f;
		}

		internal void _003CReload_003Eb__5(float v)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CReload_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClanGameOverPanel _003C_003E4__this;

		public int originHp;

		public int addToken1;

		public int addToken2;

		public long damage;

		public bool showNextBoss;

		private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass17_1 _003C_003E8__2;

		private GameCompleteRequestModel _003Cmodel_003E5__2;

		private int _003CremainBossHp_003E5__3;

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
		public _003CReload_003Ed__17(int _003C_003E1__state)
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

	[ComponentConnect]
	public CanvasGroup confirmButton;

	public LerpText dealtDamageText;

	public Text divinePowerText;

	public Image divinePowerGauge;

	public ImageTextPair damageRewardText;

	public ImageTextPair killRewardText;

	public CanvasGroup rewards;

	[ComponentConnect]
	public Image bossImage;

	[ComponentConnect]
	public Text bossNameText;

	[ComponentConnect]
	public Text phaseText;

	[ComponentConnect]
	public Image bossHpGauge;

	[ComponentConnect]
	public LerpText bossHpText;

	private long _lastDamage;

	public int originHp;

	private int totalHp;

	private int totalScore;

	private float _lastDivinePower;

	public void Show(int addToken1, int addToken2, int remainHp, long damage, bool showNextBoss, bool dontShowReward)
	{
	}

	[IteratorStateMachine(typeof(_003CReload_003Ed__17))]
	private IEnumerator Reload(int addToken1, int addToken2, int remainHp, int originHp, long damage, bool showNextBoss)
	{
		return null;
	}

	public void ReloadDivinePowerGauge(bool force = true, bool showNextBoss = false)
	{
	}

	public void SetDivinePowerGauge(float divinePower, float gaugeFill = -1f, bool force = false)
	{
	}

	public void OnClickClose()
	{
	}

	public void Close()
	{
	}
}

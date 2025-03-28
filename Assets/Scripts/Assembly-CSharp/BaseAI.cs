using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

public class BaseAI
{
	public struct AIAction
	{
		public State state;

		public float time;

		public bool keep;
	}

	public enum State
	{
		Idle = 0,
		Move = 1,
		Trace = 2,
		Attack = 3,
		Die = 4,
		RushReady = 5,
		Rush = 6,
		RushDizzy = 7,
		Hide = 8,
		Appear = 9,
		Bomb = 10,
		Stun = 11
	}

	[Serializable]
	public struct SaveDatas
	{
		public List<int> idxs;

		public List<string> ais;
	}

	public abstract class BinarySaveData : IBinarySerializer
	{
		public enum AIType
		{
			None = 0,
			ConnectedBuffer = 1,
			Count = 2
		}

		public byte type;

		public byte index;

		[UsedImplicitly]
		public BinarySaveData()
		{
		}

		public abstract string ToJson();

		public static BinarySaveData DeserializedByType(Span<byte> buffer, ref int offset)
		{
			return null;
		}

		private static BinarySaveData GetSaveDataInstanceByType(AIType type)
		{
			return null;
		}

		public virtual int GetByteSize()
		{
			return 0;
		}

		public virtual void BinarySerialize(byte[] buffer, ref int offset)
		{
		}

		public virtual void BinaryDeserialize(Span<byte> buffer, ref int offset)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CEnableAfter_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int frame;

		public BaseAI _003C_003E4__this;

		public bool v;

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
		public _003CEnableAfter_003Ed__66(int _003C_003E1__state)
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

	public GameUnit me;

	public AIAction currentAction;

	public int skillId;

	protected bool enabled;

	protected int bonusAttackCount;

	protected float atkPer;

	protected float matkPer;

	protected float defPer;

	protected float physicalDefPer;

	protected float magicDefPer;

	private bool _findTargetRequested;

	private (RangeInfo range, bool usingPathDist, HashSet<GameUnit> except, bool targetEnemy, bool excludeMe, bool setFixedTarget) _findTargetArgs;

	private static readonly List<GameUnit> _randomTargetCandidates;

	private static GameUnit _staticCheckCanAttackTargetMe;

	private static bool[] _staticCheckCanAttackTargetVisited;

	private static bool[] _staticCheckCanAttackTargetResult;

	private static readonly Func<int, int, bool> _staticCheckCanAttackTargetIterateThroughTilesFunc;

	private static int _staticGetCanAttackDistanceMinDistSqr;

	private static Vector2Int _staticGetCanAttackDistanceMinDistPos;

	private static bool _staticGetCanAttackDistanceUsePathCheck;

	private static GameUnit _staticGetCanAttackDistanceMe;

	private static GridMap _staticGetCanAttackDistanceGridMap;

	private static readonly bool[] _staticGetCanAttackDistanceVisited;

	private static readonly bool[] _staticGetCanAttackDistanceResult;

	private static readonly Func<int, int, bool> _staticGetCanAttackDistanceIterateThroughTilesFunc;

	public bool isManaLocked { get; protected set; }

	public BaseAI(GameUnit me)
	{
	}

	protected BaseAI Do(AIAction action)
	{
		return null;
	}

	protected BaseAI Do(State state, float time = -1f)
	{
		return null;
	}

	protected virtual void OnActionStart(AIAction action)
	{
	}

	protected virtual void OnAction(AIAction action)
	{
	}

	protected virtual void OnActionFixed(AIAction action)
	{
	}

	protected virtual void OnActionEnd(AIAction action)
	{
	}

	public virtual void Update(float dt)
	{
	}

	public virtual void UpdateForCheck(float dt)
	{
	}

	public void FixedUpdate()
	{
	}

	public virtual void HandleEvent(string eventName)
	{
	}

	public virtual void HandleStun(GameUnit from)
	{
	}

	[Obsolete]
	public virtual void HandleDamaged(GameUnit from, DamageInfo damageInfo)
	{
	}

	public virtual void HandleApplyDamage(GameUnit from, ref DamageInfo damageInfo)
	{
	}

	public virtual void HandleAdjustBeforeDamaged(ref DamageInfo damageInfo, GameUnit from)
	{
	}

	public virtual void HandleDie()
	{
	}

	public virtual void FindTarget(RangeInfo range, bool usingPathDist = false, HashSet<GameUnit> except = null, bool targetEnemy = true, bool excludeMe = true, bool setFixedTarget = false, bool usePathCheck = false, bool excludeSame = false, bool forceIgnoreTaunt = false)
	{
	}

	protected void CancelFindTarget()
	{
	}

	protected void FindTargetImpl(RangeInfo range, bool usingPathDist = false, HashSet<GameUnit> except = null, bool checkCanAttack = true, bool targetEnemy = true, bool excludeMe = true, bool setFixedTarget = false, bool usePathCheck = false, bool excludeSame = false, bool forceIgnoreTaunt = false)
	{
	}

	protected bool CheckCanAttackTarget(GameUnit target, bool canUseSkill, RangeInfo atkRange, RangeInfo skillRange)
	{
		return false;
	}

	private (float, Vector2Int) GetCanAttackDistance(GameUnit target, RangeInfo range, bool usePathCheck = false)
	{
		return default((float, Vector2Int));
	}

	protected virtual void HandleTargetSelected()
	{
	}

	protected void FlipToTarget()
	{
	}

	public virtual void HandleWorldObjectDestroyed()
	{
	}

	protected bool CanRush()
	{
		return false;
	}

	public virtual int GetBonusAttackCount(bool isSkill)
	{
		return 0;
	}

	public virtual float GetAtkPer()
	{
		return 0f;
	}

	public virtual float GetMAtkPer()
	{
		return 0f;
	}

	public virtual float GetDefPer()
	{
		return 0f;
	}

	public virtual float GetNormalDefPer()
	{
		return 0f;
	}

	public virtual float GetSkillDefPer()
	{
		return 0f;
	}

	public virtual void Clear()
	{
	}

	public virtual void SetEnabled(bool v, int afterFrame = 0)
	{
	}

	[IteratorStateMachine(typeof(_003CEnableAfter_003Ed__66))]
	private IEnumerator EnableAfter(bool v, int frame)
	{
		return null;
	}

	public virtual bool UseCustomSelfEffect()
	{
		return false;
	}

	public virtual bool UseCustomFindSkillTargetFunc(ResourceSkill resSkill)
	{
		return false;
	}

	public virtual List<GameUnit> CustomFindSkillTargets(ResourceSkill resourceSkill)
	{
		return null;
	}

	public virtual bool UseCustomSplashRangeFromFunc(ResourceSkill resSkill)
	{
		return false;
	}

	public virtual Vector2Int CustomSplashRangeFrom(ResourceSkill resourceSkill, Vector2Int targetPos)
	{
		return default(Vector2Int);
	}

	protected virtual void InitCustomFindTargetImplVariables()
	{
	}

	protected virtual bool CustomFindTargetImpl(bool checkCanAttack, float dist, float attackDist, GameUnit target)
	{
		return false;
	}

	public virtual void HandleStartBattle()
	{
	}

	public virtual void HandleReloadPotential()
	{
	}

	public virtual void HandleEndBattle()
	{
	}

	public virtual void HandleStopEnd()
	{
	}

	public virtual void OnInitStage()
	{
	}

	public virtual void HandleKillUnit(GameUnit target, DamageInfo damageInfo)
	{
	}

	public virtual void HandleHpRatioChanged(float beforeRatio, float afterRatio)
	{
	}

	public virtual void HandleStartChanneling()
	{
	}

	public virtual void HandleEndChanneling()
	{
	}

	public virtual void HandleChannelingSuccess()
	{
	}

	public virtual void HandleShootSkill(ResourceSkill resSkill, List<GameUnit> targets)
	{
	}

	public virtual void ShowCustomSelfEffects(IReadOnlyList<ResourceSkill.Effect> selfEffects)
	{
	}

	public virtual BinarySaveData Save(int unitIndex)
	{
		return null;
	}

	public virtual void LoadFromJson(string json)
	{
	}

	public virtual void LoadFromBinary(string binary)
	{
	}

	public virtual void Load(BinarySaveData saveData)
	{
	}

	public virtual int HandleBaseManaBuff(int mana)
	{
		return 0;
	}

	public virtual void HandleGridMapChanged()
	{
	}

	public virtual void HandleHitUnit(GameUnit target, ref DamageInfo damageInfo)
	{
	}

	public virtual int HandleHeal(int value, GameUnit from)
	{
		return 0;
	}

	public virtual long GetDivineTotalDamage()
	{
		return 0L;
	}

	public virtual Vector2Int CustomMoveToPosition()
	{
		return default(Vector2Int);
	}
}

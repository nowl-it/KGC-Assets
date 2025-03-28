using System;
using System.Collections.Generic;
using JetBrains.Annotations;

public class ConnectedBufferAI : MoveAttackAI
{
	[Serializable]
	[UsedImplicitly]
	private struct SaveDataNew
	{
		public int x;

		public int y;
	}

	public new class BinarySaveData : BaseAI.BinarySaveData
	{
		public sbyte x;

		public sbyte y;

		public override string ToJson()
		{
			return null;
		}

		public override int GetByteSize()
		{
			return 0;
		}

		public override void BinarySerialize(byte[] buffer, ref int offset)
		{
		}

		public override void BinaryDeserialize(Span<byte> buffer, ref int offset)
		{
		}
	}

	public GameUnit connectedTarget;

	public bool hasCandidate;

	private GameUnit _connectedTargetAtStartBattle;

	private bool _isLastConnectedTargetIsClone;

	private bool _isConnectedTargetLevelIsHigher;

	private bool _isConnectedTargetManaIsHigherThanTrigger;

	private int _targetManaTrigger;

	private float _healCounter;

	private float _manaHealCounter;

	public float buffChannelingTime;

	public ConnectedBufferAI(GameUnit me)
		: base(null)
	{
	}

	private void ResetTargetManaTrigger()
	{
	}

	public override void HandleStartBattle()
	{
	}

	public override void HandleReloadPotential()
	{
	}

	public override void HandleDie()
	{
	}

	private bool CheckBufferIsFront()
	{
		return false;
	}

	public override void HandleEndBattle()
	{
	}

	public void SaveConnectedTargetAtStartBattle()
	{
	}

	public override void HandleEvent(string eventName)
	{
	}

	private void RemoveBuffWhenCancelConnect()
	{
	}

	public override void SetEnabled(bool v, int afterFrame = 0)
	{
	}

	public override void Clear()
	{
	}

	public void ClearEffect()
	{
	}

	public void FindConnectedTarget(bool playSound, int recursive = 0)
	{
	}

	public override List<GameUnit> CustomFindSkillTargets(ResourceSkill resourceSkill)
	{
		return null;
	}

	public override bool UseCustomFindSkillTargetFunc(ResourceSkill resSkill)
	{
		return false;
	}

	public void ShowWaitingEffect()
	{
	}

	public override void UpdateForCheck(float dt)
	{
	}

	public void CancelChanneling()
	{
	}

	public override void HandleStopEnd()
	{
	}

	private void SetConnectedTarget(GameUnit target)
	{
	}

	public override BaseAI.BinarySaveData Save(int unitIndex)
	{
		return null;
	}

	public override void LoadFromJson(string json)
	{
	}

	public override void LoadFromBinary(string binary)
	{
	}

	public override void Load(BaseAI.BinarySaveData saveData)
	{
	}

	public override int HandleBaseManaBuff(int mana)
	{
		return 0;
	}

	private int GetAddManaByPotential()
	{
		return 0;
	}
}

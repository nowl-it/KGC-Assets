using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class DevDeckPanel : MonoBehaviour
{
	public class DevDeckSaveData
	{
		public class UnitData
		{
			public int unitNameDropdownValue;

			public int unitLevel;

			public int skinDropdownValue;

			public int potentialTier;

			public int potentialSlot;

			public int[] artifactOption;

			public TreasureSaveData equippedTreasure;

			public AccessorySaveData[] equippedAccessories;
		}

		public class TreasureSaveData
		{
			public int treasureId;

			public int treasureLevel;

			public int treasureOvercome;
		}

		public class AccessorySaveData
		{
			public int level;

			public int synergy;

			public int slot;

			public AccessoryModel.AccessoryData data;
		}

		public UnitData[] unitData;

		public int[] artifactData;

		public int[] enemyArtifactData;
	}

	public Dropdown[] dropdowns;

	public InputField[] levels;

	public Dropdown[] skinsDropdowns;

	public InputField[] potentialTiers;

	public InputField[] potentials;

	public Text[] artifactOptionTexts;

	public Text[] treasureTexts;

	public Text[] artifactTexts;

	public Text[] enemyArtifactTexts;

	public InputField enemyLevel;

	public InputField enemyPotential;

	public InputField enemyPotentialTier;

	public InputField globalLevel;

	private bool _inited;

	private bool _setted;

	public DevEquipTreasurePanel devEquipTreasurePanel;

	[NonSerialized]
	public int[] artifacts;

	[NonSerialized]
	public int[] enemyArtifacts;

	private DevDeckSaveData _saveData;

	public void Init()
	{
	}

	public void SetArtifactOptionText(int idx)
	{
	}

	public void Show()
	{
	}

	public void OnChanged()
	{
	}

	public void OnGlobalLevelSet()
	{
	}

	public void OnEnemyLevelSet()
	{
	}

	public void OnEnemyPotentialSet()
	{
	}

	public void OnEnemyPotentialTierSet()
	{
	}

	public void Close()
	{
	}

	private void UpdateSaveData()
	{
	}

	public void OnClickSave()
	{
	}

	public void OnClickLoad(bool fromClipboard)
	{
	}

	public void OnClickTreasure(int index)
	{
	}
}

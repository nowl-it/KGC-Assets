using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using CodeStage.AntiCheat.ObscuredTypes;

[Serializable]
public class PlayerData
{
	public string uid;

	public AwesomeInt level;

	public AwesomeInt exp;

	public AwesomeInt heart;

	public AwesomeInt gold;

	public AwesomeInt cash;

	public int[] currentDeck;

	public int[] currentPotential;

	public int currentDeckPreset;

	public DeckInfo[] deckInfos;

	public List<CardData> cards;

	public int[][] buildingData;

	public int buildingPoint;

	public int bestClearedStage;

	public int bestClearedTheme;

	public int lastPlayedTheme;

	public int bestClearedHardStage;

	public int bestClearedHardTheme;

	public int playedCount;

	public List<KeyValue> keyValues;

	public PlayerDataResponseModel model;

	public ObscuredInt eventFlag;

	public int remainBuildingPoint => 0;

	public string name => null;

	public string castleName => null;
}

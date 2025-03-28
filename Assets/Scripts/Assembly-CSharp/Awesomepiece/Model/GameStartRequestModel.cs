using System;
using System.Collections.Generic;

namespace Awesomepiece.Model
{
	[Serializable]
	public class GameStartRequestModel
	{
		[Serializable]
		public class DeckInfo
		{
			public int[] cards;

			public int[] buildings;

			public List<int> artifacts;
		}

		public int theme;

		public int currentDeckPreset;

		public int difficulty;

		public int targetDeck;

		public bool isArenaTraining;

		public int foodBoosterLevel;

		public int targetBoss;

		public int targetDifficulty;

		public bool isTestBattle;

		public bool isPracticeBattle;

		public bool isRetrying;

		public int barrackPreset;

		public int babelFloor;

		public bool isEventModeContinued;

		public int rogueLikeSelectedFirstHero;

		public int rogueLikeChallengeLevel;

		public bool isForceFreeRetry;

		public DeckInfo deckInfo;
	}
}

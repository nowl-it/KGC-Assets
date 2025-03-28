using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.Rendering;

public class ResourceRogueLikeEvent : ResourceBase<ResourceRogueLikeEvent>
{
	public class Node
	{
		public enum Type
		{
			Option = 0,
			PickOption = 1,
			Reward = 2,
			Action = 3,
			Condition = 4,
			Loop = 5,
			Cost = 6
		}

		public Type type;
	}

	public abstract class Executable : Node
	{
		public abstract void Execute(Executor executor);
	}

	public class Option : Node
	{
		public readonly FormatableText optionKey;

		private readonly Condition _showCondition;

		private readonly Cost _cost;

		private readonly List<Reward> _rewards;

		private readonly string[] _optionKeyArgs;

		private readonly int _targetCount;

		public Constants.RogueLikeItemType targetType { get; }

		public bool targetExceptMaxLevel { get; }

		public Option(XmlNode n, ResourceRogueLikeEvent resEvent)
		{
		}

		public bool CanShow(Executor executor)
		{
			return false;
		}

		public bool PayCost(Executor executor, out string failedReason)
		{
			failedReason = null;
			return false;
		}

		public Reward GetRandomReward(Executor executor)
		{
			return null;
		}

		public bool CheckTargetCountRequirementSatisfied(Executor executor)
		{
			return false;
		}

		public int GetSuccessRatio(Executor executor)
		{
			return 0;
		}
	}

	public class PickOption : Node
	{
		private readonly List<Node> _options;

		private readonly Number _count;

		public PickOption(XmlNode n, ResourceRogueLikeEvent resEvent)
		{
		}

		public List<Option> PickOptions(Executor executor)
		{
			return null;
		}
	}

	public class Reward : Node
	{
		private readonly Number _ratio;

		private readonly List<Executable> _executables;

		public bool isSuccessReward { get; private set; }

		public Reward(XmlNode n, ResourceRogueLikeEvent resEvent)
		{
		}

		public float GetRatio(Executor executor)
		{
			return 0f;
		}

		public void Execute(Executor executor)
		{
		}
	}

	public class Action : Executable
	{
		private readonly string _key;

		private readonly string _var;

		private readonly string _num;

		private Dictionary<string, string> _params;

		public Action(XmlNode n, ResourceRogueLikeEvent resEvent)
		{
		}

		public override void Execute(Executor executor)
		{
		}

		private string GetParamText(string key, string @default = null)
		{
			return null;
		}

		private bool GetParamBool(string key, bool @default = false)
		{
			return false;
		}

		private int GetParamInt(string key, int @default = -1)
		{
			return 0;
		}

		private float GetParamFloat(string key, int @default = -1)
		{
			return 0f;
		}

		private void SetResultItem(Constants.RogueLikeItemType type, int tier, int id, int amount)
		{
		}

		private void SetItemOwnedItem(Item item, GameUnit equippedBy)
		{
		}
	}

	public class Condition : Executable
	{
		private readonly string _key;

		private readonly string _var;

		private readonly bool _negate;

		private readonly Number _compareTo;

		private readonly int _hasGoldAdd;

		private readonly float _hasGoldMul;

		private readonly List<Executable> _executables;

		private readonly List<Executable> _elseExecutables;

		public Condition(XmlNode n, ResourceRogueLikeEvent resEvent)
		{
		}

		public bool Check(Executor executor)
		{
			return false;
		}

		public override void Execute(Executor executor)
		{
		}
	}

	public class Loop : Executable
	{
		private readonly Number _count;

		private readonly List<Executable> _executables;

		public Loop(XmlNode n, ResourceRogueLikeEvent resEvent)
		{
		}

		public override void Execute(Executor executor)
		{
		}
	}

	public class Cost : Node
	{
		private readonly string _type;

		private readonly Number _amount;

		public Cost(XmlNode n, ResourceRogueLikeEvent resEvent)
		{
		}

		public bool PayCost(Executor executor, out string failedReason)
		{
			failedReason = null;
			return false;
		}

		private void SetResultItem(Constants.RogueLikeItemType type, int tier, int id, int amount)
		{
		}
	}

	public class Number
	{
		private readonly string _text;

		private readonly float _cached;

		public Number(string text)
		{
		}

		public float GetValue(Executor executor)
		{
			return 0f;
		}

		public static float GetValue(Executor executor, string text)
		{
			return 0f;
		}
	}

	public class FormatableText
	{
		private readonly string _text;

		private readonly string[] _args;

		public FormatableText(string text, string argsText)
		{
		}

		public string Get()
		{
			return null;
		}
	}

	[Serializable]
	public class Targets
	{
		public List<RogueLikeCardData> cards;

		public List<RogueLikeArtifactModel> artifacts;

		public List<(Item item, ItemUnit itemUnit, GameUnit equippedBy)> items;
	}

	public class Variable
	{
		public string name;

		public float defaultValue;
	}

	public class Executor
	{
		[Serializable]
		public class SaveData
		{
			public int resEvent;

			public SerializedDictionary<string, float> variables;

			public List<int> eventQueue;
		}

		private ResourceRogueLikeEvent _resEvent;

		private readonly Targets _targets;

		private readonly SerializedDictionary<string, float> _variables;

		private readonly List<int> _eventQueue;

		public ResourceRogueLikeEvent resEvent => null;

		public Targets targets => null;

		public Executor()
		{
		}

		public Executor(ResourceRogueLikeEvent resEvent)
		{
		}

		public Executor(SaveData saveData)
		{
		}

		public void SetEvent(ResourceRogueLikeEvent resEvent)
		{
		}

		public void ExecuteStartActions()
		{
		}

		public void ClearVariables()
		{
		}

		private void ClearTargets()
		{
		}

		public void AddHeroToTargets(RogueLikeCardData cardData)
		{
		}

		public void AddArtifactToTargets(RogueLikeArtifactModel artifactModel)
		{
		}

		public void AddItemToTargets(Item item, ItemUnit itemUnit, GameUnit equippedBy)
		{
		}

		public List<Option> GetVisibleOptions()
		{
			return null;
		}

		public bool Execute(Option option)
		{
			return false;
		}

		public void AddEventToQueue(int eventId)
		{
		}

		public int GetQueuedEventCount()
		{
			return 0;
		}

		public void DequeueEvent()
		{
		}

		public int GetVarInt(string key, int @default = 0)
		{
			return 0;
		}

		public bool TryGetVarInt(string key, out int value)
		{
			value = default(int);
			return false;
		}

		public float GetVarFloat(string key, float @default = 0f)
		{
			return 0f;
		}

		public bool TryGetVarFloat(string key, out float value)
		{
			value = default(float);
			return false;
		}

		public void SetVar(string key, float value)
		{
		}

		public void DeclareVar(string key, float value)
		{
		}

		public SaveData ToSaveData()
		{
			return null;
		}
	}

	public class Result
	{
		private readonly FormatableText _title;

		private readonly List<FormatableText> _descs;

		private string _resultNarrative;

		private readonly string _icon;

		private readonly Condition _showCondition;

		public string title => null;

		public string resultNarrative => null;

		public string desc => null;

		public Sprite icon => null;

		public Result(XmlNode n, ResourceRogueLikeEvent resEvent)
		{
		}

		public bool CanShow()
		{
			return false;
		}
	}

	public string _title;

	public FormatableText desc;

	public string panelPrefab;

	private string _icon;

	public List<Variable> variables;

	public List<Node> options;

	public List<Executable> startActions;

	public List<Executable> openPanelActions;

	public List<Executable> endActions;

	public List<Result> results;

	public Condition showCondition;

	public string title => null;

	public Sprite icon => null;

	public override void Init(XmlNode n)
	{
	}

	private static List<Executable> ParseExecutables(XmlNodeList nodes, ResourceRogueLikeEvent resEvent)
	{
		return null;
	}

	public static void Load(System.Action callback = null)
	{
	}

	private static string ConcatString(Executor executor, string text)
	{
		return null;
	}
}

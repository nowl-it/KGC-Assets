using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ResourceCutscene : ResourceBase<ResourceCutscene>
{
	public class ID
	{
		public const int RogueLikeIntro = 10000;
	}

	public class Character
	{
		public readonly string name;

		public readonly string nameKey;

		public readonly string portrait;

		public readonly Color portraitColor;

		public Character(XmlNode n)
		{
		}
	}

	public abstract class Script
	{
		public Script(XmlNode n)
		{
		}

		public abstract void Do(CutscenePlayer player);
	}

	public class DialogueBase : Script
	{
		public string line;

		public float typingInterval;

		public DialogueBase(XmlNode n)
			: base(null)
		{
		}

		public override void Do(CutscenePlayer player)
		{
		}
	}

	public class Dialogue : DialogueBase
	{
		public string characterKey;

		public Dialogue(XmlNode n)
			: base(null)
		{
		}

		public override void Do(CutscenePlayer player)
		{
		}
	}

	public class Narration : DialogueBase
	{
		public Narration(XmlNode n)
			: base(null)
		{
		}

		public override void Do(CutscenePlayer player)
		{
		}
	}

	public class HideDialoguePanel : Script
	{
		public HideDialoguePanel(XmlNode n)
			: base(null)
		{
		}

		public override void Do(CutscenePlayer player)
		{
		}
	}

	public class WaitForAnimation : Script
	{
		public WaitForAnimation(XmlNode n)
			: base(null)
		{
		}

		public override void Do(CutscenePlayer player)
		{
		}
	}

	public class ResumeAnimation : Script
	{
		public ResumeAnimation(XmlNode n)
			: base(null)
		{
		}

		public override void Do(CutscenePlayer player)
		{
		}
	}

	public string prefab;

	public List<Character> characters;

	public List<Script> scripts;

	public override void Init(XmlNode n)
	{
	}

	public static void Load(Action callback = null)
	{
	}
}

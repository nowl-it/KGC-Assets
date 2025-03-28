using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/ToJ Effects/Character Spacing", 7)]
[RequireComponent(typeof(Text))]
public class CharacterSpacing : BaseMeshEffect
{
	private const string REGEX_TAGS = "<b>|</b>|<i>|</i>|<size=.*?>|</size>|<color=.*?>|</color>|<material=.*?>|</material>";

	[SerializeField]
	private float m_Offset;

	private List<UIVertex> m_Verts;

	public float offset
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected CharacterSpacing()
	{
	}

	public override void ModifyMesh(VertexHelper vh)
	{
	}

	private MatchCollection GetRegexMatchedTags(string text, out int lengthWithoutTags)
	{
		lengthWithoutTags = default(int);
		return null;
	}
}

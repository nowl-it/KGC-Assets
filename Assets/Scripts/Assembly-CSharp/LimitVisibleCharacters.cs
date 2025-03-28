using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
[AddComponentMenu("UI/ToJ Effects/Limit Visible Characters", 8)]
public class LimitVisibleCharacters : BaseMeshEffect
{
	private const string REGEX_TAGS = "<b>|</b>|<i>|</i>|<size=.*?>|</size>|<color=.*?>|</color>|<material=.*?>|</material>";

	[SerializeField]
	private int m_VisibleCharacterCount;

	private List<UIVertex> m_Verts;

	public int visibleCharacterCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected LimitVisibleCharacters()
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

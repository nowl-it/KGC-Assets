using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneDialogueItemBase : MonoBehaviour
{
	[SerializeField]
	protected Text _lineText;

	[SerializeField]
	protected TextFitter _lineTextFitter;

	[SerializeField]
	protected Border _border;

	private float _textTypingTimer;

	private float _textTypingInterval;

	private int _textTypingIndex;

	private string _line;

	private static string _textTypingTagFront;

	private static string _textTypingTagBack;

	private static readonly int _textTypingTagsLength;

	private StringBuilder _sb;

	public bool isFocused { get; private set; }

	public bool isTyping => false;

	public virtual void Set(CutscenePlayer.Character character, string line)
	{
	}

	public void SetTextTypingInterval(float interval)
	{
	}

	protected virtual void Update()
	{
	}

	public virtual void HandleFocusOff()
	{
	}

	public void EndTextTyping()
	{
	}
}

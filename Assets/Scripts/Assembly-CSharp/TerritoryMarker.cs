using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryMarker : MonoBehaviour
{
	public enum Type
	{
		None = 0,
		Labor = 1,
		MaxCollectableLabor = 2,
		MaxLabor = 3,
		AssignLevelSyncUnit = 4,
		HuntingCompleted = 5,
		AssignUnit = 6,
		SkinToken = 7
	}

	[SerializeField]
	private SpriteRenderer _markerSprite;

	[SerializeField]
	private Image _markerImage;

	private List<Type> _queue;

	private Type _curType;

	[SerializeField]
	private float _yOffset;

	public void Show(Type type)
	{
	}

	private void ShowImpl(Type type)
	{
	}

	public void Hide()
	{
	}

	public void SetYOffset(float y)
	{
	}

	private void Update()
	{
	}

	private Type CheckAndPopQueue()
	{
		return default(Type);
	}

	public Type GetCurType()
	{
		return default(Type);
	}

	public bool TypeExists(Type type)
	{
		return false;
	}
}

using UnityEngine;
using UnityEngine.EventSystems;

public class DragUnit : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[GetComponent]
	public GameUnit me;

	public bool draggable;

	public Vector3 originPos;

	private const float FOCUS_TOGGLE_TIME = 1.4f;

	private float _focusToggleTime;

	private bool _focusToggleSkill;

	private Vector2Int _lastFocusedPos;

	private Transform _originParent;

	private PointerEventData _beginDragPointerEventData;

	public PointerEventData beginDragPointerEventData => null;

	public void SetUpMockUpDrag()
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	private void Update()
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void UpdateGridFocus(Vector2 point)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	private void RestoreParentTransform()
	{
	}

	public void EndDragImpl(UnitGrid grid, Vector2Int tilePos, PointerEventData eventData, bool dragHandling = true)
	{
	}

	private bool Merge(GameUnit target)
	{
		return false;
	}

	private bool Equip(GameUnit target)
	{
		return false;
	}

	private bool UseToArtifact(RogueLikeArtifactModel artifactModel)
	{
		return false;
	}

	private void DestroyItem(ItemUnit myItem)
	{
	}

	public void Restore(bool position = true)
	{
	}

	public void CancelDrag()
	{
	}

	public static bool IsPointerOver(Vector2 pos, Transform target)
	{
		return false;
	}

	private bool CheckFeedable(GameUnit target, Item item, ItemUnit myItem)
	{
		return false;
	}
}

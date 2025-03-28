using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeLevelGenerator : MonoBehaviour, IClosable
{
	[Serializable]
	public class SaveData
	{
		public List<RogueLikeRoom.SaveData> rooms;

		public Vector2Int curPos;

		public List<ResourceRogueLikeRoom.Type> shownEventRooms;
	}

	public Vector2Int worldSize;

	public float roomGap;

	private ResourceRogueLikeWorld.Floor _resFloor;

	private RogueLikeRoom[,] _rooms;

	public List<Vector2Int> roomPoses;

	public Text floorText;

	public Text goldText;

	public Text heroCountText;

	[SerializeField]
	private RogueLikeRoom _roomPrefab;

	public Transform mapRoot;

	public Transform character;

	private UnitController _characterPrefab;

	private int _lastMaxLevelHero;

	public RectTransform playerChessPiece;

	public RectTransform[] finalBossesChessPiece;

	private RectTransform targetBossChessPiece;

	public Button enterAlreadyEnteredShopButton;

	[SerializeField]
	private List<Button> _buttons;

	[SerializeField]
	private Transform _fogsRoot;

	private Material _fogMaterial;

	private RogueLikeRoom _curRoom;

	private readonly SaveData _saveData;

	private readonly List<ResourceRogueLikeRoom.Type> _notShownEventRooms;

	private bool _isMoving;

	private bool _setBG;

	public RogueLikeRoom[,] rooms => null;

	public RogueLikeRoom curRoom => null;

	private Dictionary<string, Vector2Int> dirDict { get; }

	private void Awake()
	{
	}

	private void SetBG()
	{
	}

	public void Show()
	{
	}

	private void SetCharacterDirAndPos(Vector2Int dir, Vector3 pos)
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public bool MoveRoom(RogueLikeRoom target, bool force = false)
	{
		return false;
	}

	public bool MoveRoom(Vector2Int dir, bool force = false)
	{
		return false;
	}

	public void MoveRoom(string dir)
	{
	}

	public void EnterAlreadyEnteredRoom()
	{
	}

	public void MarkCurRoomAsCleared()
	{
	}

	public void SetFloor(ResourceRogueLikeWorld.Floor resFloor)
	{
	}

	public void Clear()
	{
	}

	public void CreateRooms(ResourceRogueLikeWorld.Floor resFloor)
	{
	}

	private Vector2Int NewPosition()
	{
		return default(Vector2Int);
	}

	private Vector2Int SelectiveNewPosition()
	{
		return default(Vector2Int);
	}

	private int NumberOfNeighbors(Vector2Int checkingPos, List<Vector2Int> usedPositions)
	{
		return 0;
	}

	private bool CheckSquareExist(Vector2Int checkingPos, List<Vector2Int> usedPositions)
	{
		return false;
	}

	private bool CanCreateRoom(ResourceRogueLikeRoom resRoom, List<ResourceRogueLikeRoom> existRooms)
	{
		return false;
	}

	public ResourceRogueLikeRoom.Type GetRandomEventRoom()
	{
		return default(ResourceRogueLikeRoom.Type);
	}

	public RogueLikeRoom GetRoom(ResourceRogueLikeRoom.Type type)
	{
		return null;
	}

	public List<RogueLikeRoom> GetAllRooms()
	{
		return null;
	}

	private void UpdateFogOfWar()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	public SaveData ToSaveData()
	{
		return null;
	}

	public void LoadFrom(SaveData saveData)
	{
	}
}

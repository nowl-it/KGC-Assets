using System;
using System.Collections.Generic;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[AddComponentMenu("Tilemap/Grid Information")]
	public class GridInformation : MonoBehaviour, ISerializationCallbackReceiver
	{
		internal struct GridInformationValue
		{
			public GridInformationType type;

			public object data;
		}

		[Serializable]
		internal struct GridInformationKey
		{
			public Vector3Int position;

			public string name;
		}

		private Dictionary<GridInformationKey, GridInformationValue> m_PositionProperties;

		[SerializeField]
		[HideInInspector]
		private List<GridInformationKey> m_PositionIntKeys;

		[SerializeField]
		[HideInInspector]
		private List<int> m_PositionIntValues;

		[SerializeField]
		[HideInInspector]
		private List<GridInformationKey> m_PositionStringKeys;

		[SerializeField]
		[HideInInspector]
		private List<string> m_PositionStringValues;

		[SerializeField]
		[HideInInspector]
		private List<GridInformationKey> m_PositionFloatKeys;

		[HideInInspector]
		[SerializeField]
		private List<float> m_PositionFloatValues;

		[HideInInspector]
		[SerializeField]
		private List<GridInformationKey> m_PositionDoubleKeys;

		[SerializeField]
		[HideInInspector]
		private List<double> m_PositionDoubleValues;

		[HideInInspector]
		[SerializeField]
		private List<GridInformationKey> m_PositionObjectKeys;

		[HideInInspector]
		[SerializeField]
		private List<Object> m_PositionObjectValues;

		[SerializeField]
		[HideInInspector]
		private List<GridInformationKey> m_PositionColorKeys;

		[HideInInspector]
		[SerializeField]
		private List<Color> m_PositionColorValues;

		internal Dictionary<GridInformationKey, GridInformationValue> PositionProperties => null;

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public bool SetPositionProperty<T>(Vector3Int position, string name, T positionProperty)
		{
			return false;
		}

		public bool SetPositionProperty(Vector3Int position, string name, int positionProperty)
		{
			return false;
		}

		public bool SetPositionProperty(Vector3Int position, string name, string positionProperty)
		{
			return false;
		}

		public bool SetPositionProperty(Vector3Int position, string name, float positionProperty)
		{
			return false;
		}

		public bool SetPositionProperty(Vector3Int position, string name, double positionProperty)
		{
			return false;
		}

		public bool SetPositionProperty(Vector3Int position, string name, Object positionProperty)
		{
			return false;
		}

		public bool SetPositionProperty(Vector3Int position, string name, Color positionProperty)
		{
			return false;
		}

		private bool SetPositionProperty(Vector3Int position, string name, GridInformationType dataType, object positionProperty)
		{
			return false;
		}

		public T GetPositionProperty<T>(Vector3Int position, string name, T defaultValue) where T : Object
		{
			return null;
		}

		public int GetPositionProperty(Vector3Int position, string name, int defaultValue)
		{
			return 0;
		}

		public string GetPositionProperty(Vector3Int position, string name, string defaultValue)
		{
			return null;
		}

		public float GetPositionProperty(Vector3Int position, string name, float defaultValue)
		{
			return 0f;
		}

		public double GetPositionProperty(Vector3Int position, string name, double defaultValue)
		{
			return 0.0;
		}

		public Color GetPositionProperty(Vector3Int position, string name, Color defaultValue)
		{
			return default(Color);
		}

		public bool ErasePositionProperty(Vector3Int position, string name)
		{
			return false;
		}

		public virtual void Reset()
		{
		}

		public Vector3Int[] GetAllPositions(string propertyName)
		{
			return null;
		}
	}
}

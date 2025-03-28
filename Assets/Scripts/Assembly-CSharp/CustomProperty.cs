using System;
using UnityEngine;
using com.spacepuppy.Collections;

public class CustomProperty : MonoBehaviour
{
	[Serializable]
	public class PropertyDict : SerializableDictionaryBase<string, string>
	{
	}

	[SerializeField]
	public PropertyDict properties;
}

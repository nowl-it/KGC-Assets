using System;
using System.Collections.Generic;
using System.Reflection;

namespace SRF
{
	public abstract class SRMonoBehaviourEx : SRMonoBehaviour
	{
		private struct FieldInfo
		{
			public bool AutoCreate;

			public bool AutoSet;

			public System.Reflection.FieldInfo Field;

			public bool Import;

			public Type ImportType;
		}

		private static Dictionary<Type, IList<FieldInfo>> _checkedFields;

		private static void CheckFields(SRMonoBehaviourEx instance, bool justSet = false)
		{
		}

		private static void PopulateObject(IList<FieldInfo> cache, SRMonoBehaviourEx instance, bool justSet)
		{
		}

		private static List<FieldInfo> ScanType(Type t)
		{
			return null;
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}
	}
}

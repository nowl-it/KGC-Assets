using System;

namespace SRF
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
	public sealed class RequiredFieldAttribute : Attribute
	{
		private bool _autoCreate;

		private bool _autoSearch;

		private bool _editorOnly;

		public bool AutoSearch
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AutoCreate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete]
		public bool EditorOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public RequiredFieldAttribute(bool autoSearch)
		{
		}

		public RequiredFieldAttribute()
		{
		}
	}
}

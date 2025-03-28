using System;

namespace Awesomepiece.Model
{
	[Serializable]
	public class ArtifactModel
	{
		public int id;

		public int artifactId;

		public int count;

		public int polishPoint;

		public ArtifactData data;

		public ArtifactOptions options;

		public bool[] optionLock;

		public int customType;

		public string createdAt;

		[NonSerialized]
		protected ResourceArtifact _resArtifact;

		public DateTime createdAt_ => default(DateTime);

		public ResourceArtifact resArtifact => null;

		public bool IsEventFreeUpgradeAvailable(bool checkCanChangeOption = false)
		{
			return false;
		}

		public string GetEventOptionDesc()
		{
			return null;
		}
	}
}

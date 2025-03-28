using System;
using Awesomepiece.Model;

public class RogueLikeArtifactModel : ArtifactModel
{
	[Serializable]
	public struct SaveData
	{
		public int artifactId;

		public BuildingData fixedBuildingData;

		public BuildingData randomBuildingData;
	}

	public BuildingData fixedBuildingData;

	public BuildingData randomBuildingData;

	public RogueLikeArtifactModel()
	{
	}

	public RogueLikeArtifactModel(SaveData saveData)
	{
	}

	public RogueLikeArtifactModel(ResourceArtifact resArtifact)
	{
	}

	public void Initialize(ResourceArtifact resArtifact)
	{
	}

	public SaveData ToSaveData()
	{
		return default(SaveData);
	}
}

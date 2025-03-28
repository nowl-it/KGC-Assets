public struct BoltInfo
{
	public enum BoltType
	{
		None = 0,
		SimultaneousTree = 1,
		SequentialLineDelay = 2,
		SequentialLine = 3,
		SequentialLoop = 4
	}

	public BoltType type;

	public int count;

	public float value;

	public ResourceSkill.Effect targetEffect;

	public ResourceSkill.Effect lineEffect;

	public string sound;

	public bool fromItem;

	public bool soloActive;

	public bool effectFromSelf;
}

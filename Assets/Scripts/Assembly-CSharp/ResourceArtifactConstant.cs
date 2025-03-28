using System.Xml;
using Awesomepiece.Model;

public class ResourceArtifactConstant
{
	private static int[] _craftDustCost;

	private static int[][] _dismantleDustReward;

	private static int[][] _mergeCost;

	private static int[][][] _rerollGoldCost;

	private static int[][][] _rerollCashCost;

	private static int[] _lockPolishPoint;

	private static int[] _rerollItemPolishPoint;

	private static int[] _catalystPolishPoint;

	private static int[][] _artifactPolishPointByRank;

	private static int[] _artifactPolishPointToReplace;

	private static void Init(XmlNode n)
	{
	}

	private static int[][] Make2DArray(XmlNode node)
	{
		return null;
	}

	public static int GetCraftDustCost(ResourceArtifact resArtifact)
	{
		return 0;
	}

	public static int GetDismantleDustReward(ResourceArtifact resArtifact)
	{
		return 0;
	}

	public static int GetMergeCost(ResourceArtifact resArtifact)
	{
		return 0;
	}

	public static int GetRerollGoldCost(ResourceArtifact resMaterial, ArtifactModel artifact, int lockOptionCount)
	{
		return 0;
	}

	public static int GetRerollCashCost(ResourceArtifact resMaterial, ArtifactModel artifact, int lockOptionCount)
	{
		return 0;
	}

	public static int GetLockPolishPoint(int lockOptionCount)
	{
		return 0;
	}

	public static int GetRerollItemPolishPoint(int idx)
	{
		return 0;
	}

	public static int GetCatalystItemPolishPoint(int catalystTier)
	{
		return 0;
	}

	public static int GetArtifactPolishPointByRank(ArtifactModel artifact, int rank)
	{
		return 0;
	}

	public static int GetArtifactPolishPointToReplace(ArtifactModel artifact)
	{
		return 0;
	}

	public static void Load()
	{
	}
}

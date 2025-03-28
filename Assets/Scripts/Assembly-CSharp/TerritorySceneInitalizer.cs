using System.Collections.Generic;

public class TerritorySceneInitalizer
{
	private static TerritorySceneInitalizer _instance;

	private static bool _isInitialized;

	public readonly List<BuildableArea> buildableAreas;

	public static TerritorySceneInitalizer instance => null;

	public static void Release()
	{
	}
}

using FyberPlugin;

public class FyberManager
{
	private static string APP_ID;

	private static string SECURITY_TOKEN;

	private static string GEM_PLACEMENT;

	private static string MEAT_PLACEMENT;

	private Ad fyberOfwAd;

	private bool _inited;

	public static FyberManager Instance { get; }

	public void Init()
	{
	}

	private void RequestOfferwallGem()
	{
	}

	private void RequestOfferwallFood()
	{
	}

	private void OnFyberAdAvailable(Ad ad)
	{
	}

	private void OnFyberAdNotAvailable(AdFormat adFormat)
	{
	}

	private void OnFyberRequestFail(RequestError error)
	{
	}

	public void ShowOfferwallGem()
	{
	}

	public void ShowOfferwallFood()
	{
	}
}

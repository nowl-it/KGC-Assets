using System.Reflection;

internal class StandardBoard : IBoard
{
	private static PropertyInfo m_systemCopyBufferProperty;

	private static PropertyInfo GetSystemCopyBufferProperty()
	{
		return null;
	}

	public void SetText(string str)
	{
	}

	public string GetText()
	{
		return null;
	}
}

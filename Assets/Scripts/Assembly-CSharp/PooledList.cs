using System.Collections.Generic;

public class PooledList<T>
{
	private List<T> _pool;

	private T _sample;

	public PooledList(int count, T sample)
	{
	}

	public void Rent(int count, ref List<T> lst)
	{
	}
}

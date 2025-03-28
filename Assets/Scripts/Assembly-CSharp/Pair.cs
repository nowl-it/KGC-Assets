using System;

[Serializable]
public class Pair<T1, T2>
{
	public const int SIZE = 2;

	public T1 value0;

	public T2 value1;

	public static readonly Pair<T1, T2> TrashInstance;

	public T1 Item1 => default(T1);

	public T2 Item2 => default(T2);
}

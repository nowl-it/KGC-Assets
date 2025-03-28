using System;

[Serializable]
public class Quartet<T1, T2, T3, T4>
{
	public const int SIZE = 4;

	public T1 value0;

	public T2 value1;

	public T3 value2;

	public T4 value3;

	public static readonly Quartet<T1, T2, T3, T4> TrashInstance;

	public T1 Item1 => default(T1);

	public T2 Item2 => default(T2);

	public T3 Item3 => default(T3);

	public T4 Item4 => default(T4);
}

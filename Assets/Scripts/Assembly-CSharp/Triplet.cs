using System;

[Serializable]
public class Triplet<T1, T2, T3>
{
	public const int SIZE = 3;

	public T1 value0;

	public T2 value1;

	public T3 value2;

	public static readonly Triplet<T1, T2, T3> TrashInstance;

	public T1 Item1 => default(T1);

	public T2 Item2 => default(T2);

	public T3 Item3 => default(T3);
}

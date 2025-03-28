using System.Collections;
using System.Collections.Generic;

namespace SRDebugger
{
	public interface IReadOnlyList<T> : IEnumerable<T>, IEnumerable
	{
		int Count { get; }

		T this[int index] { get; }
	}
}

using System;
using System.Runtime.CompilerServices;

public class SROptions
{
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class NumberRangeAttribute : Attribute
	{
		public readonly double Max;

		public readonly double Min;

		public NumberRangeAttribute(double min, double max)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Property)]
	public sealed class IncrementAttribute : Attribute
	{
		public readonly double Increment;

		public IncrementAttribute(double increment)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class SortAttribute : Attribute
	{
		public readonly int SortPriority;

		public SortAttribute(int priority)
		{
		}
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class DisplayNameAttribute : Attribute
	{
		public readonly string Name;

		public DisplayNameAttribute(string name)
		{
		}
	}

	private static readonly SROptions _current;

	public static SROptions Current => null;

	public event SROptionsPropertyChanged PropertyChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void OnPropertyChanged(string propertyName)
	{
	}
}

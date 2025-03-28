public struct AwesomeInt
{
	private int _value;

	private int _key;

	private int _checker;

	private bool _valueSetted;

	public int v
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public AwesomeInt(int v)
	{
		_value = 0;
		_key = 0;
		_checker = 0;
		_valueSetted = false;
	}

	public void Set(int value)
	{
	}

	public int Get()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public static AwesomeInt operator +(AwesomeInt a, AwesomeInt b)
	{
		return default(AwesomeInt);
	}

	public static AwesomeInt operator +(AwesomeInt a, int b)
	{
		return default(AwesomeInt);
	}

	public static AwesomeInt operator -(AwesomeInt a, AwesomeInt b)
	{
		return default(AwesomeInt);
	}

	public static AwesomeInt operator -(AwesomeInt a, int b)
	{
		return default(AwesomeInt);
	}

	public static AwesomeInt operator *(AwesomeInt a, AwesomeInt b)
	{
		return default(AwesomeInt);
	}

	public static AwesomeInt operator *(AwesomeInt a, int b)
	{
		return default(AwesomeInt);
	}

	public static AwesomeInt operator /(AwesomeInt a, AwesomeInt b)
	{
		return default(AwesomeInt);
	}

	public static AwesomeInt operator /(AwesomeInt a, int b)
	{
		return default(AwesomeInt);
	}

	public static bool operator ==(AwesomeInt a, AwesomeInt b)
	{
		return false;
	}

	public static bool operator !=(AwesomeInt a, AwesomeInt b)
	{
		return false;
	}

	public static bool operator ==(AwesomeInt a, int b)
	{
		return false;
	}

	public static bool operator !=(AwesomeInt a, int b)
	{
		return false;
	}

	public static bool operator >(AwesomeInt a, int b)
	{
		return false;
	}

	public static bool operator <(AwesomeInt a, int b)
	{
		return false;
	}

	public static bool operator >(AwesomeInt a, AwesomeInt b)
	{
		return false;
	}

	public static bool operator <(AwesomeInt a, AwesomeInt b)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(AwesomeInt obj)
	{
		return false;
	}

	public static explicit operator int(AwesomeInt awesomeInt)
	{
		return 0;
	}
}

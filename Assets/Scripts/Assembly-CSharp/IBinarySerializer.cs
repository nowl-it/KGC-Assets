using System;
using System.Collections.Generic;

public interface IBinarySerializer
{
	private static byte[] _byteBuffer;

	int GetByteSize();

	void BinarySerialize(byte[] buffer, ref int offset);

	void BinaryDeserialize(Span<byte> buffer, ref int offset);

	static string Serialize(IBinarySerializer obj)
	{
		return null;
	}

	static T Deserialize<T>(string base64String) where T : IBinarySerializer, new()
	{
		return default(T);
	}

	static object Deserialize(byte[] buffer, Type type)
	{
		return null;
	}

	static int GetSize<V>(V value) where V : struct
	{
		return 0;
	}

	static int GetSize(string value)
	{
		return 0;
	}

	static int GetSize<V>(List<V> list) where V : struct
	{
		return 0;
	}

	static int GetObjectListSize<V>(List<V> list) where V : IBinarySerializer
	{
		return 0;
	}

	static int GetSize<V>(V[] list) where V : struct
	{
		return 0;
	}

	static int GetObjectArraySize<V>(V[] list) where V : IBinarySerializer
	{
		return 0;
	}

	static void WriteByte<V>(byte[] buffer, ref int offset, V value) where V : struct
	{
	}

	static V ReadByte<V>(Span<byte> buffer, ref int offset) where V : struct
	{
		return default(V);
	}

	static void WriteStringToByte(byte[] buffer, ref int offset, string value)
	{
	}

	static string ReadStringFromByte(Span<byte> buffer, ref int offset)
	{
		return null;
	}

	static void WriteListToByte<V>(byte[] buffer, ref int offset, List<V> list) where V : struct
	{
	}

	static List<V> ReadListFromByte<V>(Span<byte> buffer, ref int offset) where V : struct
	{
		return null;
	}

	static void WriteObjectListToByte<V>(byte[] buffer, ref int offset, List<V> list) where V : IBinarySerializer
	{
	}

	static List<V> ReadObjectListFromByte<V>(Span<byte> buffer, ref int offset) where V : IBinarySerializer, new()
	{
		return null;
	}

	static void WriteArrayToByte<V>(byte[] buffer, ref int offset, V[] list) where V : struct
	{
	}

	static V[] ReadArrayFromByte<V>(Span<byte> buffer, ref int offset) where V : struct
	{
		return null;
	}

	static void WriteObjectArrayToByte<V>(byte[] buffer, ref int offset, V[] array) where V : IBinarySerializer
	{
	}

	static V[] ReadObjectArrayFromByte<V>(Span<byte> buffer, ref int offset) where V : IBinarySerializer, new()
	{
		return null;
	}
}

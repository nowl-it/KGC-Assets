using System.Xml;
using JetBrains.Annotations;

public interface IRecursiveInheritable<T> where T : ResourceBase<T>
{
	[CanBeNull]
	IRecursiveInheritable<T> GetParentResource();

	[NotNull]
	XmlNode GetXmlNode();
}

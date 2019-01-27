using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using UnityEngine;

[XmlRoot("Root")]
public class DialogHolder
{
	[XmlArray("DialogHolder")]
	[XmlArrayItem("d")]
	public List<DialogData> DialogDatas = new List<DialogData>();

	public static DialogHolder Load(string path)
	{
		var serializer = new XmlSerializer(typeof(DialogHolder));
		TextAsset ta = Resources.Load(path) as TextAsset;
		using(var stream = new System.IO.StringReader(ta.text))
		{
			return serializer.Deserialize(stream) as DialogHolder;
		}
	}

}
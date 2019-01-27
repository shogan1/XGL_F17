using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;

public class DialogData
{ 
	[XmlAttribute("name")]
	public string Name;

	[XmlArray("lines")]
	[XmlArrayItem("l")]
	public List<LineData> lines = new List<LineData>();

}

public class LineData
{ 
	[XmlAttribute("pic")]
	public string PictureID = "";

	// Advances automatically
	[XmlAttribute("auto")]
	public bool auto = false;


	// Doesn't lock controls. Overrides 'auto'.
	[XmlAttribute("ambient")]
	public bool ambient=false;

	[XmlText]
	public string Dialog;

}
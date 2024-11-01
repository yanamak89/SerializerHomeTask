using System.Xml.Serialization;

namespace XmlDeserializerApp;

[Serializable]
public class PersonAttributes
{
    [XmlAttribute]
    public string Name { get; set; }
    
    [XmlAttribute]
    public int Age { get; set; }
}
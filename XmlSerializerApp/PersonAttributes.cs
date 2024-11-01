using System.Xml.Serialization;

[Serializable]
public class PersonAttributes
{
    [XmlAttribute]
    public string Name { get; set; }

    [XmlAttribute]
    public int Age { get; set; }
}
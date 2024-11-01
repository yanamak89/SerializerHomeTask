using System;
using System.IO;
using System.Xml.Serialization;

public class Program
{
    public static void Main(string[] args)
    {
        // Серіалізація з елементами
        PersonElements personElements = new PersonElements { Name = "Yana", Age = 35 };
        XmlSerializer serializerElements = new XmlSerializer(typeof(PersonElements));
        using (StreamWriter writer = new StreamWriter("personAsElements.xml"))
        {
            serializerElements.Serialize(writer, personElements);
        }

        // Серіалізація з атрибутами
        PersonAttributes personAttributes = new PersonAttributes { Name = "Yana", Age = 35 };
        XmlSerializer serializerAttributes = new XmlSerializer(typeof(PersonAttributes));
        using (StreamWriter writer = new StreamWriter("personAsAttributes.xml"))
        {
            serializerAttributes.Serialize(writer, personAttributes);
        }
    }
}
# SerializationTasks

This project demonstrates various serialization and deserialization techniques in C#, specifically focusing on XML and JSON formats. The tasks cover basic serialization concepts and include code for transmitting object state over a network.

## Tasks

### [Task 2: XML Serialization](https://github.com/yanamak89/SerializerHomeTask/tree/master/XmlSerializerApp)

**Objective**: Create a class that supports serialization. Perform serialization of this object in XML format.
- First, use the default XML format where each field is represented as an XML element.
- Then, modify the XML format so that the field values are stored as XML attributes.

**Implementation**:
- Create a `Person` class with properties `Name` and `Age`.
- Use the `[XmlAttribute]` attribute to control how fields are serialized as elements or attributes.
- Serialize the object twice, once with default XML settings and once with attribute-based XML.

---

### [Task 3: XML Deserialization](https://github.com/yanamak89/SerializerHomeTask/tree/master/XmlDeserializerApp)

**Objective**: Create a new program that deserializes an object from the XML files created in Task 2. Display the state of the object on the screen.

**Implementation**:
1. Read `personAsElements.xml` and `personAsAttributes.xml`.
2. Deserialize each XML file into a `Person` object.
3. Display the properties of the deserialized object.

---

### [Task 5: JSON Serialization for Network Transfer](https://github.com/yanamak89/SerializerHomeTask/tree/master/UserJsonSerializer)

**Objective**: Create a user-defined type (e.g., a `User` class) and serialize an object of this type for network transmission.

**Implementation**:
1. Create a `User` class with properties such as `Id`, `Name`, and `Email`.
2. Use JSON serialization (e.g., `System.Text.Json`) to serialize the `User` object.
3. Save the JSON data to a file or prepare it for transmission over the network.

---

This repository provides examples to help understand serialization in C# for different scenarios, covering XML serialization with attributes and JSON serialization for network transfer.

using System.IO;
namespace MENACElib;
using System.Runtime.Serialization.Formatters.Binary;
class Serializer
{
    public void MENACESerializer(MENACE menace, string filePath) {
        BinaryFormatter bf = new();
        if (File.Exists(filePath)) File.Delete(filePath);
        FileStream fs = File.Create(filePath);
        bf.Serialize(fs, menace);
        fs.Close();
    }
    public MENACE BinaryDeserializer(string filePath) {
        MENACE m = null;
        BinaryFormatter bf = new();
        if (File.Exists(filePath)) {
            FileStream fs = File.OpenRead(filePath);

            m = bf.Deserialize(fs) as MENACE;
            fs.Close();
        }
        return m;
    }
}
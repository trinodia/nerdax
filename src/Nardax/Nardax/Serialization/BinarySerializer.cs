using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Nardax.Serialization
{
    public class BinarySerializer<T> : ISerializer<T, byte[]>
    {
        /// <summary>
        /// Serializera ett värde av valfri typ
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public byte[] Serialize(T value)
        {
            using (var stream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, value);
                return stream.ToArray();
            }
        }

        /// <summary>
        /// Deserialisera ett värde av valfri typ
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public T Deserialize(byte[] bytes)
        {
            using (var memoryStream = new MemoryStream(bytes))
            {
                var binaryFormatter = new BinaryFormatter();
                memoryStream.Position = 0;
                return (T)binaryFormatter.Deserialize(memoryStream);
            }
        }
    }
}

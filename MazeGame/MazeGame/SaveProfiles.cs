using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MazeGame
{
    public class SaveProfiles
    {
        public  List<PlayerProfile> profiles = new List<PlayerProfile>();
        private string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)+ "\\Profiles.xml";
        /*public void aoao()
        {
           PlayerProfile Save = new PlayerProfile();
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(PlayerProfile));

            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//SerializationOverview.xml";
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, overview);
            file.Close();
        }*/
        public PlayerProfile Create(string Nickname, string Email, string Password)
        {
            PlayerProfile profile = new PlayerProfile();
            profiles.Add(profile);
            return profile;
        }
        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<PlayerProfile>));
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            serializer.Serialize(stream, profiles);
            stream.Close();
        }
        public void Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<PlayerProfile>));
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            profiles = serializer.Deserialize(stream) as List<PlayerProfile>;
            stream.Close();
        }
    }
}
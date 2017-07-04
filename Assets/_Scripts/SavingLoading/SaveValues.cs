using UnityEngine;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveValues : MonoBehaviour
{
    private void Start()
    {
        if (!Directory.Exists(Values.saveFile)) Directory.CreateDirectory(Values.saveFile);
    }

    public void save()
    {
        var binary = new BinaryFormatter();
        var fstream = File.Create(Values.saveFile);
        var data = new SaveFile();

        data.MuteAudio = Values.MuteAudio;
        data.ShowSubtitles = Values.ShowSubtitles;
        data.Volume = Values.Volume;

        binary.Serialize(fstream, data);
        fstream.Close();
    }
}

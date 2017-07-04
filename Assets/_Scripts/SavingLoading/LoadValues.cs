using UnityEngine;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class LoadValues : MonoBehaviour 
{
    public void load()
    {
        if (!File.Exists(Values.saveFile)) return;
        var formatter = new BinaryFormatter();
        var fstream = File.Open(Values.saveFile, FileMode.Open);
        var data = formatter.Deserialize(fstream) as SaveFile;

        Values.MuteAudio = data.MuteAudio;
        Values.ShowSubtitles = data.ShowSubtitles;
        Values.Volume = data.Volume;

        fstream.Close();
    }
}

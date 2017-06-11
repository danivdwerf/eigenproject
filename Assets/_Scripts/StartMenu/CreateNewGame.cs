using UnityEngine;
using System.IO;

public class CreateNewGame : MonoBehaviour 
{
    private HandleStartscreenButtons buttons;

    private void Start()
    {
        buttons = this.GetComponent<HandleStartscreenButtons>();
        buttons.OnNewGame += createGame;
    }

    private void createGame()
    {
        var path = Application.persistentDataPath + "/safedata";
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        
        FileStream fStream = File.Create(path + "Safe.dat");
        fStream.Close();
    }
}

using UnityEngine;
using System.IO;

public class CreateNewGame : MonoBehaviour 
{
    private SaveValues saveValues;
    private void Start()
    {
        GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<HandleStartscreenButtons>().OnNewGame += createGame;
        saveValues = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<SaveValues>();
    }

    private void createGame()
    {
        saveValues.save();
    }
}

using System;

using UnityEngine;
using UnityEngine.UI;

public class HandleStartscreenButtons : MonoBehaviour 
{
    [SerializeField]private Button newGameButton;
    public event Action OnNewGame;

    [SerializeField]private Button settingsButton;
    public event Action OnSettings;

    [SerializeField]private Button exitButton;
    public event Action OnExit;

    private void Start()
    {
        setListeners();
    }

    private void setListeners()
    {
        newGameButton.onClick.AddListener(delegate(){if(OnNewGame!=null) OnNewGame();});
        settingsButton.onClick.AddListener(delegate(){if(OnSettings!=null)OnSettings();});
        exitButton.onClick.AddListener(delegate(){if(OnExit!=null) OnExit();});
    }
}

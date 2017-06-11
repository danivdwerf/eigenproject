using UnityEngine;
using UnityEngine.UI;

public class HandleSettingsButtons : MonoBehaviour 
{
    [SerializeField]private Button audioSettings;
    [SerializeField]private Button backButton;

    private ShowPanel panels;

    private void Start()
    {
        panels = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<ShowPanel>();
        setListeners();
    }

    private void setListeners()
    {
        audioSettings.onClick.AddListener(delegate(){panels.showPanel(Panels.audioSettings, true, false);});
        backButton.onClick.AddListener(delegate(){panels.showPanel(Panels.startscreen, true, true);});
    }
}

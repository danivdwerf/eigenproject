using UnityEngine;
using UnityEngine.UI;

public class HandleSettingsButtons : MonoBehaviour 
{
    [SerializeField]private Button audioSettings;
    [SerializeField]private Button qualitySettings;
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
        qualitySettings.onClick.AddListener(delegate(){panels.showPanel(Panels.qualitySettings, true, false);});
        backButton.onClick.AddListener(delegate(){panels.showPanel(Panels.startscreen, true, true);});
    }
}

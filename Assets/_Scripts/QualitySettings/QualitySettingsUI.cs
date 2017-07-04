using UnityEngine;
using UnityEngine.UI;

public class QualitySettingsUI : MonoBehaviour 
{
    [SerializeField]private Button backButton;

    private ShowPanel panels;

    private void Start()
    {
        setReferences();
        setListeners();
    }

    private void setReferences()
    {
        panels = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<ShowPanel>();
    }

    private void setListeners()
    {
        backButton.onClick.AddListener(delegate(){panels.showPanel(Panels.settingscreen, true, true);});
    }
}

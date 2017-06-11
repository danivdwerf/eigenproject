using UnityEngine;
using UnityEngine.UI;

public class ExitUI : MonoBehaviour 
{
    [SerializeField]private GameObject confirmWindow;
    private Button confirmButton;
    private Button cancelButton;

    private HandleStartscreenButtons buttonLogic;
    private ShowPanel showPanel;

    private void Start()
    {
        buttonLogic = this.GetComponent<HandleStartscreenButtons>();
        buttonLogic.OnExit += showConfirmation;

        showPanel = this.GetComponent<ShowPanel>();

        var buttons = confirmWindow.GetComponentsInChildren<Button>();
        confirmButton = buttons[0];
        cancelButton = buttons[1];

        confirmButton.onClick.AddListener(delegate(){Application.Quit();});
        cancelButton.onClick.AddListener(delegate(){hideConfirmation();});
    }

    private void showConfirmation()
    {
        showPanel.showPanel(Panels.exitConfirmation, true, false);
    }

    private void hideConfirmation()
    {
        showPanel.showPanel(Panels.exitConfirmation, false, false);
        showPanel.showPanel(Panels.startscreen, true, true);
    }
}

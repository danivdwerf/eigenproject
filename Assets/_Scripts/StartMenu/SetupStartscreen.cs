using System.Collections.Generic;
using UnityEngine;

public class SetupStartscreen : MonoBehaviour 
{
    private Splashscreen splashscreen;
    private HandleStartscreenButtons buttons;
    private ShowPanel showPanel;

    private void Start()
    {
        setReferences();
        splashscreen.OnSplashscreenEnd += this.showStartPanel;
        buttons.OnSettings += this.showSettingPanel;
        showPanel.showPanel(Panels.splashscreen, true, true);
    }

    private void setReferences()
    {
        splashscreen = this.GetComponent<Splashscreen>();
        showPanel = this.GetComponent<ShowPanel>();
        buttons = this.GetComponent<HandleStartscreenButtons>();
    }

    private void showStartPanel()
    {
        splashscreen.OnSplashscreenEnd -= this.showStartPanel;
        showPanel.showPanel(Panels.startscreen, true, true);
    }
    private void showSettingPanel(){showPanel.showPanel(Panels.settingscreen, true, true);}
}

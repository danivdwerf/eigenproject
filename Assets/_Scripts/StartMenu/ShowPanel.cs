using UnityEngine;
using System;
using System.Collections.Generic;
public enum Panels
{
    splashscreen = 0,
    startscreen = 1,
    exitConfirmation = 2,
    settingscreen = 3,
    audioSettings = 4,
    qualitySettings = 5
}

public class ShowPanel : MonoBehaviour
{
    [SerializeField]private GameObject[] panels;
    [SerializeField]private List<ButtonNavigation> navigationScripts;
    public event Action<int> OnPanelChange;

    private void Awake()
    {
        navigationScripts = new List<ButtonNavigation>();
        for (var i = 0; i < panels.Length; i++)
        {
            ButtonNavigation nav;
            if ((nav = panels[i].GetComponent<ButtonNavigation>()))
                navigationScripts.Add(nav);
            else
                navigationScripts.Add(null);
        }
    }


    public void showPanel(Panels panel, bool value, bool hideOthers)
    {
        var panelId = (int)panel;
        if (hideOthers)
        {
            for (var i = 0; i < panels.Length; i++)
            {
                if (panelId == i)
                    continue;
                panels[i].SetActive(false);
            }
        }

        for (var i = 0; i < navigationScripts.Count; i++)
        {
            if (navigationScripts[i] != null)
                navigationScripts[i].enabled = false;
        }

        panels[panelId].SetActive(value);
        if (navigationScripts[panelId] != null)
            navigationScripts[panelId].enabled = true;
        if (OnPanelChange != null)
            OnPanelChange(panelId);
    }
}

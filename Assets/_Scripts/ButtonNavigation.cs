using UnityEngine;
using UnityEngine.UI;

using System.Collections.Generic;

public class ButtonNavigation : MonoBehaviour 
{
    private enum NavigationType{horizontal, vertical};
    [SerializeField]private NavigationType navigation;

    private List<Selectable> selectables;
    private string selectAxis;
    private int selectedIndex;
    private bool holding;

    private void Start()
    {
        selectables = new List<Selectable>();
        var things = this.GetComponentsInChildren<Selectable>();
        if (things.Length == 0)
        {
            this.enabled = false;
            return;
        }
        for (var i = 0; i < things.Length; i++)
        {
            if (things[i].IsActive())
                selectables.Add(things[i]);
                
        }
        if (navigation == NavigationType.horizontal)
            selectAxis = Controller.LeftStickX;
        if (navigation == NavigationType.vertical)
            selectAxis = Controller.LeftStickY;
        holding = false;
    }

    private void OnEnable()
    {
        if (selectables == null)
            return;
        selectedIndex = 0;
        select();
    }

    private void select(){selectables[selectedIndex].Select();}

    private void Update()
    {
        var input = Input.GetAxisRaw(selectAxis);
        if (input >= -0.5f && input <= 0.5f)
            holding = false;
        
        if (input > 0.8f && !holding)
        {
            selectedIndex++;
            holding = true;
        }

        if (input < -0.8f && !holding)
        {
            selectedIndex--;
            holding = true;
        }

        if (selectedIndex >= selectables.Count)
            selectedIndex = 0;
        if (selectedIndex < 0)
            selectedIndex = selectables.Count - 1;

        select();
    }
}

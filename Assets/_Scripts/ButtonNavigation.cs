using UnityEngine;
using UnityEngine.UI;

public class ButtonNavigation : MonoBehaviour 
{
    private enum NavigationType{horizontal, vertical};
    [SerializeField]private NavigationType navigation;

    private Selectable[] selectables;
    private string selectAxis;
    private int selectedIndex;
    private bool holding;

    private void Start()
    {
        selectables = this.GetComponentsInChildren<Selectable>();
        if (this.selectables.Length == 0)
            this.enabled = false;
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

        if (selectedIndex >= selectables.Length)
            selectedIndex = 0;
        if (selectedIndex < 0)
            selectedIndex = selectables.Length - 1;

        select();
    }
}

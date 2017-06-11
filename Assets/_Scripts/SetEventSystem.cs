using UnityEngine;
using UnityEngine.EventSystems;


public class SetEventSystem : MonoBehaviour 
{
    [SerializeField]private StandaloneInputModule inputModule;

    private void Start()
    {
        inputModule.horizontalAxis = Controller.LeftStickX;
        inputModule.verticalAxis = Controller.LeftStickY;
        inputModule.submitButton = Controller.Cross;
        inputModule.cancelButton = Controller.Circle;
    }
}

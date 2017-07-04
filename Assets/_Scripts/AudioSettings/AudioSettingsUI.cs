using UnityEngine;
using UnityEngine.UI;

public class AudioSettingsUI : MonoBehaviour 
{
    [SerializeField]private Text volumeValue;
    [SerializeField]private Slider volumeSlider;
    [SerializeField]private Toggle muteButton;
    [SerializeField]private Toggle subtitleButton;
    [SerializeField]private Button backButton;
    private ShowPanel panels;

    private void Start()
    {
        panels = GameObject.FindGameObjectWithTag(Tags.gameController).GetComponent<ShowPanel>();
        setEventListeners();
        updateVolumeText();
    }

    private void setStartValues()
    {
        muteButton.isOn = false;
        subtitleButton.isOn = true;
    }

    private void updateVolumeText(){volumeValue.text = "Volume: " + Mathf.Round(volumeSlider.value*100) + "%";}

    private void setEventListeners()
    {
        volumeSlider.onValueChanged.AddListener(delegate{updateVolumeText(); Values.Volume = volumeSlider.value;});
        muteButton.onValueChanged.AddListener(delegate{Values.MuteAudio = muteButton.isOn;});
        subtitleButton.onValueChanged.AddListener(delegate{Values.ShowSubtitles = subtitleButton.isOn;});
        backButton.onClick.AddListener(delegate(){panels.showPanel(Panels.settingscreen, true, true);});
    }
}

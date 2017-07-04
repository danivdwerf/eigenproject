using UnityEngine;

public class Helena : MonoBehaviour 
{
    [SerializeField]private AudioClip dialogue;
    private DialogueManager dialogueManager;
    private AudioManager audioManager;
    private int dialogue1;

    private void Start()
    {
        setReferences();
        dialogue1 = audioManager.audioToID("Helena-Dialogue1");
    }

    private void setReferences()
    {
        dialogueManager = GameObject.FindGameObjectWithTag(Tags.dialogueManager).GetComponent<DialogueManager>();
        audioManager = GameObject.FindGameObjectWithTag(Tags.audioManager).GetComponent<AudioManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) audioManager.playSound(dialogue1);
    }
}

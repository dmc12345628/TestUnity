using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<MyDialogueManager>().StartDialogue(dialogue);
        Debug.Log("TriggerDialogue Call !!");
    }
}

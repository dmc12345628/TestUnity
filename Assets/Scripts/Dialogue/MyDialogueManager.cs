using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyDialogueManager : MonoBehaviour {

    public Text nameText;
    public Text dialogueText;

    private Queue</*DialogueSentences*/string> sentences;

	void Start () {
        sentences = new Queue</*DialogueSentences*/string>();
	}

    public void StartDialogue (Dialogue dialogue)
    {
        

       

        sentences.Clear();

        foreach(/*DialogueSentences*/string dialogueSentence in dialogue.sentences)
        {
            sentences.Enqueue(dialogueSentence);
        }


        DisplayNextSentence();

    }
	
    public void DisplayNextSentence()
    {

        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        /*DialogueSentences*/string dialogueSentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(dialogueSentence));
    }

    IEnumerator TypeSentence (string dialogueSentence)
    {
        dialogueText.text = "";
        foreach (char letter in dialogueSentence./*sentence.*/ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
	

    void EndDialogue()
    {
        Debug.Log("End conversation.");
    }
}

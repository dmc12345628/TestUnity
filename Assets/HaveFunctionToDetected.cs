using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class HaveFunctionToDetected : MonoBehaviour, ITrackableEventHandler

{

    private TrackableBehaviour mTrackableBehaviour;

    public Animator animationClips;
    public string booleanNameToTrack = "";
    public DialogueTrigger dialogue;

    public Animator animatorBubble;
    public string booleanNameToBubble = "";
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour){
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {

            // Play  when target is found

            animationClips.SetBool(booleanNameToTrack, true);
            StartCoroutine(StartDialogue());
            StartCoroutine(OpenBubble());
        }

        else
        {
            // Stop  when target is lost

        }

    }

    


    IEnumerator StartDialogue()
    {
        yield return new WaitForSeconds(2.5f);
        dialogue.TriggerDialogue();
    }

    IEnumerator OpenBubble()
    {
        yield return new WaitForSeconds(1.0f);
        animatorBubble.SetBool(booleanNameToBubble, true);
    }

}
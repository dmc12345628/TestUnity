using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMarkerFoundFunction : MonoBehaviour {

    public bool dialogueStarted = false;

    public GameObject canvas;

    void OnMarkerFound(ARMarker marker)
    {
        Debug.Log("MARKER "+ marker.Tag +" FOUND! WHEEEE!");

        switch (marker.Tag)
        {
            case "peluchonMarker":
                if (!dialogueStarted)
                {
                canvas.SetActive(true);
                }
                dialogueStarted = true;
                break;
        }
        
    }

    void OnMarkerLost(ARMarker marker)
    {
        Debug.Log("MARKER LOST! WHEEEE!");
    }

    void OnMarkerTracked(ARMarker marker)
    {
        Debug.Log("MARKER Tracked ! WHEEEE!");
    }
}

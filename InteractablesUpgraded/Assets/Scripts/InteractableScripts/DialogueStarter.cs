using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueStarter : Interactable
{
    public string startOfDialogue;

    public override void OnInteract(){
        //Debug.Log("Dialogue Started");
        DialogueStart startTalking = new DialogueStart();
        // Indicate which dialogue is the first
        startTalking.firstDialogue = startOfDialogue;

        EvtSystem.EventDispatcher.Raise<DialogueStart>(startTalking);
    }
}

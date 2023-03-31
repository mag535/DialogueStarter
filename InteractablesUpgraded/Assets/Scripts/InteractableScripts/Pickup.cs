using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : Interactable
{
    public override void OnInteract()
    {
        // FIXME: Delete tooltip before gameObject
        HoverTip thisTip = gameObject.GetComponent<HoverTip>();
        thisTip.OnDisable();
        
        // Delete object
        OnDisable();
        Destroy(gameObject);
    }
}

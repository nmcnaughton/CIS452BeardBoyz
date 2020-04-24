using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : PickupSuperClass
{
    public GameObject itemObject;

    public override void PlaySoundFX()
    {
        Debug.Log("Playsound 1");

    }
    public override void UpdatePlayerHUD()
    {
        Debug.Log("add score 1");
    }
    public override void DestroyObject()
    {
        Debug.Log("destroyobject");
        Destroy(itemObject);
    }
}

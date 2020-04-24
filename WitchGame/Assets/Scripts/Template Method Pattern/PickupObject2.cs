using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject2 : PickupSuperClass
{
    public GameObject itemObject2;
    public override void PlaySoundFX()
    {
        Debug.Log("Playsound 2");

    }
    public override void UpdatePlayerHUD()
    {
        Debug.Log("add score 2");
    }
    public override void DestroyObject()
    {
        Debug.Log("destroyobject");
        Destroy(itemObject2);
    }
}

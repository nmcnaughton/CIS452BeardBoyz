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
        Debug.Log("add score ");
        GameManager.Instance.currentScore++;
        Debug.Log(GameManager.Instance.currentScore);
        GameObject.FindGameObjectWithTag("UI").GetComponent<PlayerUI>().scoreEvent.Invoke();
    }
    public override void DestroyObject()
    {
        Debug.Log("destroyobject");
        Destroy(itemObject2);
    }
}

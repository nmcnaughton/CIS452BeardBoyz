using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickupSuperClass : MonoBehaviour
{
    
    


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Player picks up object");
            PickupObject(); //calling temp method

            
        }
    }
    public void PickupObject() //tempmethod
    {
        PlaySoundFX();
        DestroyObject();
        UpdatePlayerHUD();
        
    }

    public abstract void PlaySoundFX();
    public abstract void UpdatePlayerHUD();
    public abstract void DestroyObject();
}

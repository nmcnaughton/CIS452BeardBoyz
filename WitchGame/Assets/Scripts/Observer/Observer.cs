using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer<T> : MonoBehaviour where T : Component
{
    void OnNotify()
    {

    }
}

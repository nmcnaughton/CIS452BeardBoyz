using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject<T> : MonoBehaviour where T : Component
{
    List<IObserver> observers;

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Notify()
    {
        foreach (IObserver ob in observers)
        {
            ob.OnNotify();
        }
    }

    public void RemoveObserver(IObserver observer)
    {
        throw new System.NotImplementedException();
    }
}

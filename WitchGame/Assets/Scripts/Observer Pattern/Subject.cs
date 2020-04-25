using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    List<Observer> observers = new List<Observer>();

    public virtual void AddObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public virtual void Notify()
    {
        foreach (Observer ob in observers)
        {
            ob.OnNotify();
        }
    }

    public virtual void RemoveObserver(Observer observer)
    {
        observers.Remove(observer);
    }
}

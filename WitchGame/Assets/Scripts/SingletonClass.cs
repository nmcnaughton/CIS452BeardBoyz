using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonClass<T> : MonoBehaviour where T : Component
{
    // Creates a private instance of T, destroys any new instances of 
    //T, persists through scenes, and automatically creates a GameObject
    //to attach to, meaning we don't need to place it into any scene hierarchy.
    //Just inherit from this class to make any class a Singleton

    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = "T";
                    _instance = obj.AddComponent<T>();
                    DontDestroyOnLoad(obj);
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
    }
}

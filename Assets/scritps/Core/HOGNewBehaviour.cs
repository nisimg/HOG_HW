using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HOGNewBehaviour : MonoBehaviour
{
    HOGManager Instance => HOGManager.Instance;
}

public class HOGManager
{
    public static HOGManager Instance;
    public HOGManager()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    
    
    
}

public class HOGLoader : MonoBehaviour
{
    private void Start()
    {
        Invoke(nameof(Init),0.1f);
    }

    public void Init()
    {
        new HOGManager();
        Destroy(this.gameObject);
    }
}

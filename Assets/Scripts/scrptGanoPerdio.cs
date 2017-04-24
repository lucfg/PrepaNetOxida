using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrptGanoPerdio : MonoBehaviour {

    public bool gano =true;
   
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}

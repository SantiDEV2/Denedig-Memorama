using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyCamara : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}

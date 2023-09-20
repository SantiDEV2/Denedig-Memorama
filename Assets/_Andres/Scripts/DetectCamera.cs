using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DetectCamera : MonoBehaviour
{
    public GameObject dd;

    void Awake()
    {
        dd = GameObject.FindGameObjectWithTag("MainCamera"); 
    }

    void Start()
    {
        this.GetComponent<TMP_Dropdown>().onValueChanged.AddListener(delegate { Debug.Log("test"); });
    }
}

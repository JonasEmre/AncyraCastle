using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat : MonoBehaviour
{
    private Image content;

    private float currentValue;


    public float MyCurrentValue { get => currentValue; set => currentValue = value }


    void Start()
    {
        content = GetComponent<Image>();
    }

    void Update()
    {
        
    }
}

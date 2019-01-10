using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    public Slider sliderRotation;
    public Slider sliderPower; 
    public float rotation;
    public float power;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation = sliderRotation.value;
        power = sliderPower.value;
    }
}

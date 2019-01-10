using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Slider slider;

    

    public void RotateCannon()
    {
        transform.rotation = Quaternion.Euler(0, 0, (slider.value));
    }

}

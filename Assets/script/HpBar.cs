using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    //script is used but due to no damage taken it is not seen

    public Slider hpSlider;

    public void InitBar(float maxValue)
    {
        hpSlider.maxValue = maxValue;
        hpSlider.value = maxValue;
    }

    public void SetValue(float hpvalue)
    {
        hpSlider.value = hpvalue;
    }

}
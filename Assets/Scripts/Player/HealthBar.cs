using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public Slider slider;
    
    //Sets the current health
    public void SetHealth(int health)
    {
        slider.value = health;
    }

    //Sets the given max health
     public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
}

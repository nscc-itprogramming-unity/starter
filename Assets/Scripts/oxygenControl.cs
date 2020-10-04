using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxygenControl : MonoBehaviour
{
    public Slider oxygenBar;
    public floatValue oxygen;
    public GameObject youDied;
    // Start is called before the first frame update
    void Start()
    {
        oxygen.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        //relates the oxygen bar value to the oxygen value
        oxygenBar.value = oxygen.value;

        //drains oxygen bar
        if (oxygen.value > 0)
        {
            oxygen.value -= 2 * Time.deltaTime;
        }
        //checks if suffocated
        if(oxygen.value <= 0)
        {
            Time.timeScale = 0;
            youDied.SetActive(true);
        }
    }
}

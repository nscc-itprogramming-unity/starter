using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxygenControl : MonoBehaviour
{
    public Slider oxygenBar;
    public floatValue inspiration;
    public GameObject youDied;
    // Start is called before the first frame update
    void Start()
    {
        inspiration.value = 100;
        youDied.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //relates the oxygen bar value to the oxygen value
        oxygenBar.value = inspiration.value;
    }

    void Reduce(int amount)
    {
        inspiration.value -= amount;
    }
}

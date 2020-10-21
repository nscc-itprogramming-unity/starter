using UnityEngine;
using System;

public class GameEndDestroyEvent : MonoBehaviour
{

    void OnEnable()
    {
        EventManager.OnGameStateChange += OnGameEndEvent;
    }

    void OnDisable()
    {
        EventManager.OnGameStateChange -= OnGameEndEvent;
    }

    void OnGameEndEvent(bool successful)
    {
        DestroyImmediate(gameObject);
    }

}

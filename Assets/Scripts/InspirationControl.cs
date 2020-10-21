using UnityEngine;
using UnityEngine.UI;

public class InspirationControl : MonoBehaviour
{
    public Slider inspirationBar;

    public FloatValue inspiration;

    public GameObject youDied;

    void Start()
    {
        inspiration.value = 100;
        youDied.SetActive(false);
    }

    void Update()
    {
        if (youDied.activeSelf)
        {
            return;
        }
        inspirationBar.value = inspiration.value;

        if (inspirationBar.value <= 0.0)
        {
            youDied.SetActive(true);
            OnEnd();
        }
    }

    void OnEnd()
    {
        EventManager.ChangeGameState(false);
    }
}

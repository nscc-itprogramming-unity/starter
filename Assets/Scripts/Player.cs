using UnityEngine;

public class Player : MonoBehaviour
{

    public floatValue inspiration;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnInspirationEmpty()
    {

    }

    public void ReduceInspiration(float amount)
    {
        if (inspiration.value <= 0.0)
        {
            throw new PlayerInspirationEmptyException();
        }
        if (amount > inspiration.value)
        {
            amount = inspiration.value;
        }
        inspiration.value -= amount;

        if (inspiration.value <= 0.0)
        {
            OnInspirationEmpty();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collided = collision.gameObject;

        if (collided.tag == "Enemy")
        {
            //TODO amount is arbitrary/hardcoded, add something definitive
            ReduceInspiration(10);
            Destroy(collided);
        }
    }


}

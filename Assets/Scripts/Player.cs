using UnityEngine;

public class Player : MonoBehaviour
{

    public FloatValue inspiration;

    void Start()
    {

    }

    void Update()
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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collided = collision.gameObject;

        if (collided.tag == "Enemy")
        {
            //TODO amount is arbitrary/hardcoded, add something definitive
            ReduceInspiration(50);
            Destroy(collided);
        }
    }


}

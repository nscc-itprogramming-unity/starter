using UnityEngine;

/**
 * The purpose of this class is to allow an object to move in a negative
 * direction on the x-axis.
 * 
 * @author Jason MacKeigan
 */
public class LinearMovement : MonoBehaviour
{


    [Range(0.0f, 1.0f)]
    public float speed;

    private Rigidbody2D rigidbody;

    public void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        rigidbody.velocity = Vector2.left * speed;
    }

}

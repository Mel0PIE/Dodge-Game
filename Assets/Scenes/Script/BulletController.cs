using UnityEngine;

public class BulletController : MonoBehaviour
{
    Rigidbody rigidbody;

    public float speed = 3f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.linearVelocity = transform.forward * speed;
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController player = other.GetComponent<PlayerController>();

            if (player != null)
                player.Die();
        }
        else if (other.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}

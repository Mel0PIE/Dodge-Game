using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidbody;

    public float moveSpeed = 5f;

    private Vector3 moveVec;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveVec.x = Input.GetAxis("Horizontal");
        moveVec.z = Input.GetAxis("Vertical");
        moveVec.y = 0f;

        rigidbody.linearVelocity = moveVec * moveSpeed;
    }

    public void Die()
    {
        gameObject.SetActive(false);
        UiController uicontroller = FindObjectOfType<UiController>();
        uicontroller.EndGame();
    }
}



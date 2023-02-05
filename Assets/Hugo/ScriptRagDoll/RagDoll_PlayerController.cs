using UnityEngine;

public class RagDoll_PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    public Rigidbody hips;

    public bool isGrounded;


    // Start is called before the first frame update
    void Start()
    {
        hips = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


            Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput);
            hips.velocity = direction * speed;
            this.transform.forward = direction;
    }
}

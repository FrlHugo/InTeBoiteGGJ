using UnityEngine;

public class RagDoll_PlayerController : MonoBehaviour
{
    public float speed;
    public float strafeSpeed;
    public float jumpForce;

    public Rigidbody hips;

    public bool isGrounded;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        hips = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        if (verticalInput != 0)
        {
            hips.AddForce(hips.transform.forward * speed);
        }
        
        if (horizontalInput != 0)
        {
            hips.AddForce(-hips.transform.forward * strafeSpeed);
        }
        /*
        if (verticalInput < 0)
        {
            hips.AddForce(-hips.transform.forward * speed);
        }

        if (horizontalInput > 0)
        {
            hips.AddForce(hips.transform.right * strafeSpeed);
        }
        */
        if (Input.GetKey(KeyCode.Space))
        {
            if (isGrounded)
            { 
                hips.AddForce(new Vector3(0, jumpForce, 0));
                isGrounded = false;
            }
        }
    }

    private void Update()
    {
        if (hips.velocity.x > 0.5f || hips.velocity.x < -0.5f || hips.velocity.z > 0.5f || hips.velocity.z < -0.5f)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}

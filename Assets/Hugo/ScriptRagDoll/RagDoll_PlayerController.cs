using UnityEngine;

public class RagDoll_PlayerController : MonoBehaviour
{
    public float speed;

    public Rigidbody hips;

    public Animator animator;

    public Transform player;


    void Start()
    {
        hips = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0f, verticalInput);

        if (horizontalInput > 0 || horizontalInput < 0 || verticalInput > 0 || verticalInput < 0)
        {
            hips.velocity = direction * speed;
            //transform.forward = direction;
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}

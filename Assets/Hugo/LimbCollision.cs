using UnityEngine;

public class LimbCollision : MonoBehaviour
{
    public RagDoll_PlayerController playerController;

    private void Start()
    {
        playerController = FindObjectOfType<RagDoll_PlayerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //playerController.isGrounded = true;
    }
}

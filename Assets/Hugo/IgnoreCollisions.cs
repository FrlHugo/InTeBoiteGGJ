using UnityEngine;
using System.Collections.Generic;

public class IgnoreCollisions : MonoBehaviour
{
    public List<Collider> colliders;


    void Start()
    {
        var sphereColliders = GetComponentsInChildren<SphereCollider>();
        var capsuleColliders = GetComponentsInChildren<CapsuleCollider>();

        foreach (SphereCollider sc in sphereColliders)
        {
            colliders.Add(sc);
        }

        foreach (CapsuleCollider cc in capsuleColliders)
        {
            colliders.Add(cc);
        }

        for (int i = 0; i < colliders.Count; i++)
        {
            for (int k = i + 1; k < colliders.Count; k++)
            {
                Physics.IgnoreCollision(colliders[i], colliders[k]);
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Physics.IgnoreCollision(this.gameObject.GetComponent<MeshCollider>(), col.gameObject.GetComponent<MeshCollider>());
        }
    }
}

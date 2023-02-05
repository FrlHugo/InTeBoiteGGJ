using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class EtatTriggerZone : MonoBehaviour
{

    public bool pickUp;
    // Start is called before the first frame update
    void Start()
    {
        pickUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Corps"))
        {
            PickUpToge player = other.GetComponentInParent<IgnoreCollisions>().gameObject.GetComponent<PickUpToge>();
            player.Bonsoir(gameObject.GetComponent<Collider>());


        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    [SerializeField] private Animator LeverAnimator1;
 
    // Update is called once per frame
    void Update()
    {
        if (1f == 2f)
        {
            LeverAnimator1.SetTrigger("activate");
    
        }
    }
}

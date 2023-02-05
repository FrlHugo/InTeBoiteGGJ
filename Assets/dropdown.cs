using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropdown : MonoBehaviour
{
    public KeyCode grabKey;
    public string Name ;

    public void Update()
    {
        if (Input.GetKey(grabKey))
        {
            this.GetComponent<Animator>().SetTrigger(Name);
        }
    }
}

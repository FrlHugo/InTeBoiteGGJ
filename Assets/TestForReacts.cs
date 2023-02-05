using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PublicManaged
{
    public class TestForReacts : MonoBehaviour
    {

        public KeyCode grabKey;
        public GameObject publicobject;

        public void Update()
        {
            if (Input.GetKey(grabKey))
            {
                publicobject.GetComponent<PublicManager>().React(false, 2);
            }

        }
    }
}

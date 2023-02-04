using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActivateItems
{
    public class ActivableItem : MonoBehaviour
    {
        [SerializeField] private Rigidbody m_Rigidbody;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void TriggerActivation()
        {
            m_Rigidbody.useGravity = true;
        }

    }



}
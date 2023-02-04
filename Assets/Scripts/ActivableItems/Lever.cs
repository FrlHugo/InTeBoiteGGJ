using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ActivateItems
{
    public class Lever : MonoBehaviour
    {

        [SerializeField] private bool StartOpen;
        [SerializeField] private Transform m_MovingPart;
        [SerializeField] private GameObject m_LinkedObject;
        // Start is called before the first frame update
        void Start()
        {
            if (StartOpen)
            {
                m_MovingPart.SetLocalPositionAndRotation(m_MovingPart.position, new Quaternion(0, 0, 0, 40));
            }
            else
            {
                m_MovingPart.SetLocalPositionAndRotation(m_MovingPart.position, new Quaternion(0, 0, 0, -5));
            }
        }
        
        // Update is called once per frame
        void Update()
        {
             if (m_MovingPart.localEulerAngles.z >= 35 && m_MovingPart.localEulerAngles.z <= 45)
            {
                Debug.Log("yes");
                m_LinkedObject.GetComponent<ActivableItem>().TriggerActivation();
            }
        }
    }

}

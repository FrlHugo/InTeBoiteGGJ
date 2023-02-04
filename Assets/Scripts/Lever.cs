using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{

    [SerializeField] private bool StartOpen;
    [SerializeField] private Transform m_MovingPart;
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
        if(m_MovingPart.localEulerAngles.z >= 35f)
        {
        
        }
        else if (m_MovingPart.localEulerAngles.z <= -35f)
        {
          
        }
    }
}

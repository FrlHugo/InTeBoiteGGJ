using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PublicManaged
{
    public class PublicManager : MonoBehaviour
    {
        public GameObject[] PositiveReacts;
        public GameObject[] NegativeReacts;
        public Transform[] Reactionpositions;



        public void React(bool Good, int Amount)
        {
            for (int i  = 0; i < Amount ; i++) 
            {
                if (Good)
                {
                    Instantiate(PositiveReacts[Random.Range(0, PositiveReacts.Length)], Reactionpositions[Random.Range(0, Reactionpositions.Length)].position, Quaternion.AngleAxis(45, Vector3.right));
                }
                else
                {
                    Instantiate(NegativeReacts[Random.Range(0, NegativeReacts.Length)], Reactionpositions[Random.Range(0, Reactionpositions.Length)].position, Quaternion.AngleAxis(45, Vector3.right));
                }
            }
                

           
        }
    }
}

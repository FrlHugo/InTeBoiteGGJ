using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInCenter : MonoBehaviour
{
    public NarrateurManager narrateurManager;

    public int epreuveIndex;
    public int missionIndex;


    private void Start()
    {
        narrateurManager = FindObjectOfType<NarrateurManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            narrateurManager.epreuves[epreuveIndex].missions[missionIndex] = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            narrateurManager.epreuves[epreuveIndex].missions[missionIndex] = false;
        }
    }
}

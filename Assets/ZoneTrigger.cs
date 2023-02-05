using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTrigger : MonoBehaviour
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
        if (other.gameObject.CompareTag("Item") || other.gameObject.CompareTag("Tunique"))
        {
            narrateurManager.epreuves[epreuveIndex].missions[missionIndex] = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Item") || other.gameObject.CompareTag("Tunique"))
        {
            narrateurManager.epreuves[epreuveIndex].missions[missionIndex] = false;
        }
    }
}

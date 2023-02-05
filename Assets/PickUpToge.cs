using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpToge : MonoBehaviour
{
    public GameObject visuelToge;
    public GameObject visuelPeruque;
    public GameObject visuelNez;

    public GameObject dernierTriggerRamasser;
    public GameObject nouveauTrigger;


    public bool isWearingAToge;
    // Start is called before the first frame update
    void Start()
    {
        isWearingAToge = false;
        visuelToge.SetActive(false);
        visuelPeruque.SetActive(false);
        visuelNez.SetActive(false);
        dernierTriggerRamasser = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Toge" || other.gameObject.tag == "Peruque" || other.gameObject.tag == "Nez")
        {
            nouveauTrigger = other.gameObject;

            isWearingAToge = false;
            visuelToge.SetActive(false);
            visuelPeruque.SetActive(false);
            visuelNez.SetActive(false);

            if (other.gameObject.tag == "Toge")
            {
                isWearingAToge = true;
                visuelToge.SetActive(true);

            }

            if (other.gameObject.tag == "Peruque")
            {
                visuelPeruque.SetActive(true);

            }

            if (other.gameObject.tag == "Nez")
            {

                visuelNez.SetActive(true);
            }

            nouveauTrigger.GetComponent<EtatTriggerZone>().pickUp = false;

            dernierTriggerRamasser.GetComponent<EtatTriggerZone>().pickUp = false;

            dernierTriggerRamasser.SetActive(true);

            dernierTriggerRamasser = nouveauTrigger;

            dernierTriggerRamasser.SetActive(false);

            nouveauTrigger = null;

        }

    }
}

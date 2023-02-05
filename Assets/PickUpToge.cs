using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PickUpToge : MonoBehaviour
{
    public GameObject visuelToge;
    public GameObject visuelPeruque;
    public GameObject visuelNez;

    public GameObject dernierTriggerRamasser;
    public GameObject nouveauTrigger;

    public NarrateurManager nm;

    public bool isWearingAToge;
    // Start is called before the first frame update
    void Start()
    {
        isWearingAToge = false;
        visuelToge.SetActive(false);
        visuelPeruque.SetActive(false);
        visuelNez.SetActive(false);
        dernierTriggerRamasser = null;
        nouveauTrigger = null;
        nm = FindObjectOfType<NarrateurManager>();
    }

    public void Bonsoir(Collider other)
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
                if(nm.index == 1 || nm.index == 4)
                {
                    for (int i = 0; i< nm.epreuves[nm.index].Count; i++)
                    {
                        if (!nm.epreuves[nm.index][i])
                        {
                            nm.epreuves[nm.index][i] = true;
                            break;
                        }
                    }
                }
             

            }

            if (other.gameObject.tag == "Peruque")
            {
                visuelPeruque.SetActive(true);

            }

            if (other.gameObject.tag == "Nez")
            {

                visuelNez.SetActive(true);
            }

            nouveauTrigger.GetComponent<EtatTriggerZone>().pickUp = true;

            if(dernierTriggerRamasser != null)
            {
                dernierTriggerRamasser.GetComponent<EtatTriggerZone>().pickUp = false;

                dernierTriggerRamasser.SetActive(true);

                dernierTriggerRamasser = nouveauTrigger;

                dernierTriggerRamasser.SetActive(false);

                nouveauTrigger = null;

            }
            else
            {
                dernierTriggerRamasser = nouveauTrigger;
                dernierTriggerRamasser.SetActive(false);

            }
        }

    }
}

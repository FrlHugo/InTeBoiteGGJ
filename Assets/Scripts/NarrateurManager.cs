using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NarrateurManager : MonoBehaviour
{
    public List<SO_Narration> epreuves;
    private int index = 0;

    public TextMeshProUGUI epreuveText;

    public GameObject panel;
    public bool game = false;

    public float timer = 0f;
    private bool start = false;

    public List<GameObject> togesTrigger;
    public int togesIndex;



    void Start()
    {
        SwitchText(epreuves[index].phrase);
    }

    void Update()
    {
        if (game)
        {
            timer += Time.deltaTime;

            if (!start)
            {
                StartEpreuve();
            }
            else
            {
                SwitchEpreuve();

                foreach (GameObject go in togesTrigger)
                {
                    if (go.GetComponent<EtatTriggerZone>().pickUp)
                    {
                        togesIndex++;
                    }
                }

                if (togesIndex == 4)
                {
                    for (int i = 0; i < epreuves[1].missions.Count; i++)
                    {
                        epreuves[1].missions[i] = false;
                    }
                }
            }
        }
    }

    private void SwitchText(string text)
    {
        epreuveText.text = text;
    }

    private void StartEpreuve()
    {
        if (timer > epreuves[index].time)
        {
            index++;
            SwitchText(epreuves[index].phrase);
            start = true;
        }
    }

    private void SwitchEpreuve()
    {
        foreach (bool mission in epreuves[index].missions)
        {
            if (!mission)
            {
                return;
            }
        }

        index++;
        SwitchText(epreuves[index].phrase);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NarrateurManager : MonoBehaviour
{
    public List<SO_Narration> epreuves;
    public int index = 0;

    public TextMeshProUGUI epreuveText;

    public GameObject panel;
    public bool game = false;

    public float timer = 0f;
    private bool start = false;

    public List<GameObject> togesTrigger;
    public int togesIndex;

    public EventManager em;
    public bool test = false;



    void Start()
    {
        SwitchText(epreuves[index].phrase);
        em = FindObjectOfType<EventManager>();
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

                if (index == 3 && !test)
                {
                    int rand = Random.Range(0, 4);

                    for (int i = 0; i < em.players.Length; i++)
                    {
                        if (em.players[i] = em.players[rand])
                        {
                            print("sjlkdghnls");
                            em.players[i].GetComponentInChildren<PickUpToge>().visuelNez.SetActive(true);
                        }

                    }

                    test = true;
                }

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

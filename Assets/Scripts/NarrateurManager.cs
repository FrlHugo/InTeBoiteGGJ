using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NarrateurManager : MonoBehaviour
{
    public List<SO_Narration> epreuves;
    private int index = 0;

    public TextMeshProUGUI epreuveText;

    public float timer = 0f;
    private bool start = false;



    void Start()
    {
        SwitchText(epreuves[index].phrase);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (!start)
        {
            StartEpreuve();
        }
        else
        {
            SwitchEpreuve();
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

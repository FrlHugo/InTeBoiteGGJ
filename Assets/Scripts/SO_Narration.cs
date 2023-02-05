using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Narration", menuName = "ScriptableObjects/Narration", order = 1)]
public class SO_Narration : ScriptableObject
{
    [TextArea]
    public string phrase;

    public List<bool> missions;

    public float time;


    private void OnEnable()
    {
        for (int i = 0; i < missions.Count; i++)
        {
            missions[i] = false;
        }
    }
}
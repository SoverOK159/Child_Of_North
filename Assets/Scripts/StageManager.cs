using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    [SerializeField] int numberOfQuests;
    [SerializeField] int completedQuests;

    private void Start()
    {
        completedQuests = 0;
    }

    public int CompletedQuests
    {
        get { return completedQuests; }
        set { completedQuests = value; }
    }


    public void CheckForLevelEnd()
    {
        if(completedQuests == numberOfQuests)
        {
            Debug.Log("Area complete. You can go to next area");
        }
        else
        {
            Debug.Log("I need to find amswewrs...");
        }
    }
}

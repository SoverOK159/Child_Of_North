using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    [SerializeField] Environment item;

    private void Start()
    {
        item.IsChecked = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        Interact(item.EnvItemName);
        if (item.IsKey && !item.IsChecked)
        {
            FindObjectOfType<StageManager>().CompletedQuests += 1;
            item.IsChecked = true;
            Debug.Log(item.EnvItemMainDescription);
            Debug.Log(FindObjectOfType<StageManager>().CompletedQuests);
        }
        else
        {
            Debug.Log(item.EnvItemCheckedDescription);
        }
    }

    private void Interact(string triggerToInteract)
    {
        switch (triggerToInteract)
        {
            case ("Area End"):
                AreaExit();
                break;

            default:
                break;
        }
    }

    private void AreaExit()
    {
        FindObjectOfType<StageManager>().CheckForLevelEnd();
    }
}

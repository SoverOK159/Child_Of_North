using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    [SerializeField] Environment item;

    public void OnTriggerEnter(Collider other)
    {
        Interact(item.EnvItemName);
        Debug.Log(item.EnvItemName);
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
        Debug.Log("Check for exit from area ");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    [SerializeField] string triggerName;

    public void OnTriggerEnter(Collider other)
    {
        triggerName = this.name;
        Interact(triggerName);
    }

    private void Interact(string triggerToInteract)
    {
        switch (triggerToInteract)
        {
            case ("AreaExit"):
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(this.tag == "Item")
        {
            if (other.GetComponent<Inventory>().AddItem(this.name))
            {
                Destroy(this.gameObject);
            }
        }

        else if (this.tag == "Door")
        {
            Debug.Log("Check for key");
            if(this.name != "Fake Door")
            {
                if (other.GetComponent<Inventory>().CheckForItem(this.name + " Key"))
                {
                    Debug.Log("Key exist");
                    Debug.Log("You can open a door");
                }
                else
                {
                    Debug.Log("You need to find " + this.name + " Key");
                }
            }
            else
            {
                Debug.Log("This is fake door");
                return;
            }

            

        }
    }
}

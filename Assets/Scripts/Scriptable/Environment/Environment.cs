using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Environmetn Item", menuName ="Environment")]
public class Environment : ScriptableObject
{
    [SerializeField] string eItemName;

    public string EItemName 
    {
        get { return eItemName; }
    }
}

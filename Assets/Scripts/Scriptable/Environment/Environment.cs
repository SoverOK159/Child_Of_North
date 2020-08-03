using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Environmetn Item", menuName ="Environment")]
public class Environment : ScriptableObject
{
    [SerializeField] string envItemName = "test";

    public string EnvItemName 
    {
        get { return envItemName; }
    }
}

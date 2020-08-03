using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Environmetn Item", menuName ="Environment")]
public class Environment : ScriptableObject
{
    [SerializeField] string envItemName;
    [TextArea(10,40)][SerializeField] string envItemMainDescription;
    [TextArea(10,40)][SerializeField] string envItemCheckedDescription;
    [SerializeField] bool isKey;
    [SerializeField] bool isChecked;


    public string EnvItemName 
    {
        get { return envItemName; }
    }
    public string EnvItemMainDescription
    {
        get { return envItemMainDescription; }
    }
    public string EnvItemCheckedDescription
    {
        get { return envItemCheckedDescription; }
    }

    public bool IsKey
    {
        get { return isKey; }
    }
    public bool IsChecked
    {
        get { return isChecked; }
        set { isChecked = value; }
    }

}

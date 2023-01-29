using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Controller Variant", menuName = "ControllerVariant")] //way of quickly creating new variants of the scriptable object template in menu
public class ControllerVariant : ScriptableObject //inherets from scriptable objects library
{

    //all the variables of data for the scriptable object
   //can create game object variable but can only put prefabs/models/data from the folders in this slot, not objects from the scene


    public Material controllerMaterial; 
    public float Price;
    public string controllerName;




}




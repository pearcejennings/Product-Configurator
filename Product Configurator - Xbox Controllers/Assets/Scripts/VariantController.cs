using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class VariantController : MonoBehaviour
{
    private GameObject controllerOBJ;

    public TextMeshProUGUI variantName;
    public TextMeshProUGUI variantPrice;

    private ControllerVariant currentVariant;
    public ControllerVariant BlackCarbon;
    public ControllerVariant[] arrayOfVariants = new ControllerVariant[5]; //array of controller scriptable objects

    

    public void Start()
    {
 
        controllerOBJ = Instantiate(Resources.Load("Controller Object", typeof(GameObject))) as GameObject;     //instantiating prefab model as gameobject and making it equal to private gameobject
        controllerOBJ.GetComponent<MeshRenderer>().material = BlackCarbon.controllerMaterial;                   //same method for as the change variant function, but to specify the starting variant     
        variantName.text = BlackCarbon.controllerName;
        variantPrice.text = BlackCarbon.Price.ToString();

  
    }


    public void ChangeVariant(int index)        //int based array to be used for the onclick 
    {
        
        if (index >= arrayOfVariants.Length) return;                                                                    // checking the variant is in the list (number will be specificed in the on click)
        currentVariant = arrayOfVariants[index];                                                                        //saying the currentVariant variable is equal to the current variant in the array 
        controllerOBJ.GetComponent<MeshRenderer>().material = currentVariant.controllerMaterial;                        //make the material of the controllerPrefab = to the material of the current particular variant in the array 
        variantName.text = currentVariant.controllerName;                                                               //and then the same thing for name and price
        variantPrice.text = currentVariant.Price.ToString();                                                            //'ToString' allows the conversion of the price variable from a float to a string
        

    }

    public void resetRotation()
    {
        controllerOBJ.transform.rotation = Quaternion.Euler(90, 0, 180);
    }

}



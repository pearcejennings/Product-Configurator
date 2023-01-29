using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    public GameObject Controller;
    public Material[] materials = new Material[6];

    public void changeMaterial(int index)
    {
        if (index >= materials.Length) return;
        Controller.GetComponent<MeshRenderer>().material = materials[index];

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpen : MonoBehaviour
{
    public GameObject Panel;
    public Animator MoveBackAnimation;
   

    public void OpenPanel()
    {

        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
 
        }


    }


    void Update()
    {
        if (Panel.activeInHierarchy == false)
        {
            MoveBackAnimation.Play("DoNothing");
        }

    }

}

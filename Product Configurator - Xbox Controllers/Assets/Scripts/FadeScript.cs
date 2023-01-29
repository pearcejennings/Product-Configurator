using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeScript : MonoBehaviour
{
    [SerializeField] private CanvasGroup myUIGroup;

    void Start()
    {
        myUIGroup.alpha = 0;

        Invoke("ShowUI", 5);
    }

    public void ShowUI()
    {
        myUIGroup.alpha = 1;
    }


}

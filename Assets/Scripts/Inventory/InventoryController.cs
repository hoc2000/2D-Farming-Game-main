using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject toolbarPanel;
    public bool isOpen = false;
    GameObject dialogue;

    

    void Update()
    {
        if (Time.timeScale == 0)
            return;


        if (Input.GetKeyDown(KeyCode.E) )
        {
            panel.SetActive(!panel.activeInHierarchy);
            toolbarPanel.SetActive(!toolbarPanel.activeInHierarchy);
            if (panel.activeInHierarchy)
                isOpen = true;
            else
                isOpen = false;
        }
    }
}

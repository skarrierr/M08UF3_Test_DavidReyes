using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public RectTransform rect;
    public GameObject Inventario;

    public bool isActive;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (isActive)
            {
                Inventario.SetActive(false);
                isActive = false;
            }
            else
            {
                Inventario.SetActive(true);
                isActive = true;
            }
        }
    }
}

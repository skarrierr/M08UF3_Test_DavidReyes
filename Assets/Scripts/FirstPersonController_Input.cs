using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FirstPersonController))]
public class FirstPersonController_Input : MonoBehaviour
{
    public GameObject PanelInventario;

    FirstPersonController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<FirstPersonController>();
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        controller.Move(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")), Time.fixedDeltaTime);

        if (Input.GetKeyDown(KeyCode.I))
        {

        }
    }
    private void LateUpdate()
    {
        controller.Look(new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")));
    }
}

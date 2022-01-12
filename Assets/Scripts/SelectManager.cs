using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    void Update()
    {
        SelectObject();
    }

    void SelectObject()
    {
        RaycastHit raycastHit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        bool hasHit = Physics.Raycast(ray, out raycastHit);

        if (hasHit)
        {
            if (Input.GetMouseButton(0))
            {
                print("Selected object is: " + raycastHit.transform.name);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFound : MonoBehaviour
{
    [SerializeField] int attempts;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Seek();

            if (attempts <= 0)
            {
                
            }
        }
    }

    private void Seek()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.tag == "Error")
            {
                Destroy(gameObject);
            }
            else
            {
                attempts = attempts - 1;
            }
        }
    }

}

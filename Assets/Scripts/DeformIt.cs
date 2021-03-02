using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeformIt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        RaycastHit hit;

        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.name=="Rock")
                {
                    Destroy(hit.collider.gameObject);

                }
            }
        }
        
        

    }
}

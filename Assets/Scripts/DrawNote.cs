using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawNote : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    bool wasHit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)|| Input.GetMouseButton(1))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                
                if (hit.collider.name == "slot"&& Input.GetMouseButton(0))
                {
                    hit.collider.gameObject.transform.Find("beatFace").gameObject.SetActive(true);
                    print("was hit");
                    wasHit = true;
                }
                else if (hit.collider.name == "slot" && Input.GetMouseButton(1))
                {
                    hit.collider.gameObject.transform.Find("beatFace").gameObject.SetActive(false);
                    print("off");
                    wasHit = true;
                }



            }
        }
        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
        {
            wasHit = false;
        }
    }
    
}

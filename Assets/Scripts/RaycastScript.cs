using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");

        //odwracamy osie, poniewaz przeprowadzimy wokol nich rotacje
        transform.Rotate(dirY, -dirX, 0);

        CheckForRaycastHit();
    }
    
    void CheckForRaycastHit()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            print(hit.collider.gameObject.name + " zniszczony!");
            Destroy(hit.collider.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toque : MonoBehaviour
{
    public Camera camera;

    void Update()
    {
        if(Input.touchCount == 1)
        {
            Ray ray =camera.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit acertei;

            if(Physics.Raycast(ray, out acertei))
            {
                Destroy(acertei.collider.gameObject);
            }
        }   
    }
}

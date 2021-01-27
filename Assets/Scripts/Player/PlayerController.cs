using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Moved)
            {
                if(t.deltaPosition.y > 5)
                {
                    transform.position += Vector3.up * 1;
                }

                if (t.deltaPosition.y < -5)
                {
                    transform.position += Vector3.up * 1;
                }
            }
        }
    }
}

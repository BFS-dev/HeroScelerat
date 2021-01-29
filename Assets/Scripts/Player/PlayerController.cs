using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Update is called once per frame
    public Animator animator;
    public Joystick joystick;
    float inputX = 0;
    float inputY = 0;
    public float speed = 2.5f;
    bool isWalking = false;

    void Start() {
        isWalking = false;
    }

    void Update()
    {
        inputX = joystick.Horizontal;
        inputY = joystick.Vertical;
        isWalking = (inputX != 0 || inputY != 0) ? true : false;

        if (isWalking) {
            var move = new Vector3(inputX, inputY, 0).normalized;
            transform.position += move * speed * Time.deltaTime;
            animator.SetFloat("posX", inputX);
            animator.SetFloat("posY", inputY);
        }

        animator.SetBool("isWalking", isWalking);
        /* if(Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            Vector3 aux = Camera.main.ScreenToWorldPoint(t.position);
            aux.z = 0;
            transform.position = aux;
            /*
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
        }*/
    }
}

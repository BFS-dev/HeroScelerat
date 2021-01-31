using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public Joystick joystick;
    float inputX = 0;
    float inputY = 0;
    public float speed = 2.5f;
    bool isWalking = false;
    public float runSpeed = 2.0f;
    bool isRunning = false;

    [SerializeField]
    private GameObject correr;

    [SerializeField]
    private GameObject stop;

    void Start() {
        isWalking = false;
        isRunning = false;
    }

    void Update()
    {
        inputX = joystick.Horizontal;
        inputY = joystick.Vertical;
        isWalking = (inputX != 0 || inputY != 0) ? true : false;

        if (isWalking) {
            var move = new Vector3(inputX, inputY, 0).normalized;
            if (isRunning) {
                transform.position += move * speed * Time.deltaTime * runSpeed;
            } else {
                transform.position += move * speed * Time.deltaTime;
            }
            animator.SetFloat("posX", inputX);
            animator.SetFloat("posY", inputY);
        }

        animator.SetBool("isWalking", isWalking);
    }

    public void run()
    {
        isRunning = true;
        stop.gameObject.SetActive(true);
        correr.gameObject.SetActive(false);
    }

    public void stop_run()
    {
        isRunning = false;
        stop.gameObject.SetActive(false);
        correr.gameObject.SetActive(true);
    }
}

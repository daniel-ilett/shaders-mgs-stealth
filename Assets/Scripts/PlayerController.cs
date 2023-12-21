using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        bool isRunning = (Input.GetKey(KeyCode.Space));
        animator.SetBool("IsRunning", isRunning);
    }
}

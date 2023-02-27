using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolAnimationController : MonoBehaviour
{

    public Animator animator;

    private void Start()
    {
        animator = this.GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && (!animator.GetBool("IsBouncing")))
        {
            animator.SetBool("IsBouncing", true);
        }

        else if (Input.GetKeyDown(KeyCode.Q) && (animator.GetBool("IsBouncing")))
        {
            animator.SetBool("IsBouncing", false);
        }
    }
}

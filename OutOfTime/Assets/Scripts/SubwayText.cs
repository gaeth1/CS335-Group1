using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubwayText : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        StopAllCoroutines();
        StartCoroutine(wait());
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(6);
        animator.SetBool("isOpen", true);
    }
}

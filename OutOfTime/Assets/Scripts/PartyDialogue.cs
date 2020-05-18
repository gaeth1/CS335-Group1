using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    {
        StopAllCoroutines();
        StartCoroutine(wait());       
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(11);
        animator.SetBool("isOpen", true);

    }
}

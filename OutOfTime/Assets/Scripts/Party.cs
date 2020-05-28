using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Party : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public Animator thoughtAnimator;
    public Button startConv;
    void Start()
    {   
        FindObjectOfType<AudioManger>().Play("Party");
        thoughtAnimator.SetBool("isOpen", true);
        StopAllCoroutines();
        StartCoroutine(wait());
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(10);
        animator.SetBool("isOpen", true);
        thoughtAnimator.SetBool("isOpen", false);
        yield return new WaitForSeconds(1);
        startConv.onClick.Invoke();       
    }
}

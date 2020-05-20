using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartyDialogue : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    void Start()
    {   
        StopAllCoroutines();
        StartCoroutine(wait());       
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(5);
        animator.SetBool("isOpen", true);        
        //FindObjectOfType<AudioManger>().Play("Party");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

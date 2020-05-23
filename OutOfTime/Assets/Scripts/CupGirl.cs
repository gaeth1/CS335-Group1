using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CupGirl : MonoBehaviour  {
    // Start is called before the first frame update
    private Queue<string> sentences; 
    public Text nameText;
    public Text dialogueText;
    public Animator animator;

    void Start()
    {
        sentences=new Queue<string>();
    }
    public void StartDialogue(Dialogue dialogue){
        animator.SetBool("isOpen", true);
        nameText.text=dialogue.name;
        sentences.Clear();

        foreach(string sentance in dialogue.sentances){
            sentences.Enqueue(sentance);
        }
        DisplayNextSentance();
    }

    public void DisplayNextSentance(){
        if(sentences.Count==0){
            EndDialogue();
            return;
        }
        string sentance =sentences.Dequeue();
        dialogueText.text=sentance;
        StopAllCoroutines();
        StartCoroutine(TypeSentance(sentance));
    }

    IEnumerator TypeSentance(string sentance){
        dialogueText.text = "";
        foreach(char letter in sentance.ToCharArray()){
            dialogueText.text+=letter;
            yield return new WaitForSeconds((float) 0.05);
        }
    }
    void EndDialogue(){
        animator.SetBool("isOpen", false);
        
        
    }   

}

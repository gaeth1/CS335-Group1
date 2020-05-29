using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CafeManger : MonoBehaviour
{
    private Queue<string> sentences; 
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    public Button startConv;
    int counter=0;
    public LoadScene sceneManger; 

    void Start()
    {
        FindObjectOfType<AudioManger>().Play("Party");
        sentences=new Queue<string>();
        startConv.onClick.Invoke();       

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
        counter++;
        string sentance =sentences.Dequeue();
        dialogueText.color = new Color32(255, 61, 210,255);

        if(counter==2 || counter==8 || counter == 10 || counter==11){
            dialogueText.color = Color.blue;
        }
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
    public void EndDialogue(){
        animator.SetBool("isOpen", false);
        FindObjectOfType<AudioManger>().Play("Text");
        sceneManger.FadeToLevel(10);
    }   
}

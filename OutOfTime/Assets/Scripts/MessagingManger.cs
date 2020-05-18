using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagingManger : MonoBehaviour
{   
    public Text nameText;
    public Text dialogueText;
    public Text nameText1;
    public Text dialogueText1;

    public Animator animator;
    public Animator animator1;
    public Animator optionsAnimator;

    // Start is called before the first frame update
    public Queue<string> sentances;
    public Button firstButton;
    public Button secondButton;
    void Start()
    {
        sentances = new Queue<string>();
        firstButton.onClick.Invoke();
    }
    public void StartDialogue(Dialogue dialogue){
        animator.SetBool("isOpen", true);
        // animator1.SetBool("isOpen", true);

        nameText.text = dialogue.name;
        sentances.Clear();
        foreach(string sentance in dialogue.sentances){
            sentances.Enqueue(sentance);
        }
        DisplayNextSentances();
    }

    public void DisplayNextSentances(){
        FindObjectOfType<AudioManger>().Play("soundEffect1");
        if(sentances.Count==0){
            EndDialogue();
            return;
        }
        string sentance = sentances.Dequeue();
        dialogueText.text = sentance;
        secondButton.onClick.Invoke();

    }
    public void StartDialogue1(Dialogue dialogue){
        animator1.SetBool("isOpen", true);
        nameText1.text = dialogue.name;
        sentances.Clear();
        foreach(string sentance in dialogue.sentances){
            sentances.Enqueue(sentance);
        }
        DisplayNextSentances1();
    }

    public void DisplayNextSentances1(){
        FindObjectOfType<AudioManger>().Play("soundEffect1");
        if(sentances.Count==0){
            EndDialogue1();
            return;
        }
        string sentance = sentances.Dequeue();
        dialogueText1.text = sentance;

    }
    void EndDialogue(){
        animator.SetBool("isOpen", false);

    }

    void EndDialogue1(){
        animator1.SetBool("isOpen", false);
        optionsAnimator.SetBool("isOpen", true);
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    public Animator animator;
    private int levelToLoad;

    public void FadeToLevel (int levelIndex){
        animator.SetTrigger("FadeOut");
        levelToLoad=levelIndex;
    }

    public void onFadeComplete(){
        SceneManager.LoadScene(levelToLoad);
    }

}

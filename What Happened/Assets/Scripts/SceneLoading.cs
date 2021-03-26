using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    private bool statement = false;
    private Animator animator;
    private static SceneLoading sceneLoading;
    private AsyncOperation asyncLoadingScene;
    [SerializeField] private static bool openScene = true;
    [SerializeField] private float animationLength;
    
    private void Start()
    {

        animator = GetComponent<Animator>();
        sceneLoading = this;
        if (openScene)
        {
            sceneLoading.animator.SetTrigger("sceneOpening");
        }
        //print(sceneLoading.asyncLoadingScene.progress);
    }

    internal static void ChangeScene(string sceneName)
    {
        if (!sceneLoading.statement)
        {
            sceneLoading.animator.SetTrigger("sceneClosing");
            sceneLoading.asyncLoadingScene = SceneManager.LoadSceneAsync(sceneName);
            sceneLoading.asyncLoadingScene.allowSceneActivation = false;
            sceneLoading.Invoke("OnAniamtionOver", sceneLoading.animationLength);
            sceneLoading.statement = true;
        }
    }

    private void OnAniamtionOver()
    {
        openScene = true;
        asyncLoadingScene.allowSceneActivation = true;
    }
}

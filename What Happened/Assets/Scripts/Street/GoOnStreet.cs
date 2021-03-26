using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoOnStreet : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.GetInt("OnTheStreet") == 1)
        {
            SceneManager.LoadScene("Street");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null && PlayerPrefs.GetInt("AllowToStreet") == 1)
        {
            PlayerPrefs.SetInt("OnTheStreet", 1);
            SceneLoading.ChangeScene("Street");
        }
    }
}

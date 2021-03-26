using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SecondCharacterHolder : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject TexrmuxButton;

    public void OnPointerClick(PointerEventData eventData)
    {
        PlayerPrefs.SetInt("Termux", 1);
        SwitchOnTermuxButton();
    }

    private void Start()
    {
        if (PlayerPrefs.GetInt("Termux") == 1)
            SwitchOnTermuxButton();
    }

    private void SwitchOnTermuxButton()
    {
            TexrmuxButton.SetActive(true);      
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionBetweenRooms : MonoBehaviour
{
    private Animator animator;

    private void Start() 
    {
        animator = GetComponent<Animator>(); // initialize animator component
    }
    private void OnEnable() // subscribe on events
    {
        CorridorMiniGame._changeStateOfMiniGame += Animation;
        RoomsData.changeStateOfMiniGame += Animation;
        WalllsControll._transition += Animation;
        RoomsData._transition += Animation;
    }

    private void OnDisable()
    {
        CorridorMiniGame._changeStateOfMiniGame -= Animation;
        RoomsData.changeStateOfMiniGame -= Animation;
        WalllsControll._transition -= Animation;
        RoomsData._transition -= Animation;
    }

    private void Animation()
    {
        animator.SetTrigger("Transition");  // set animation trigger
    }
}

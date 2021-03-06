using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private void Update()
    {
        //move camera to the player position
        transform.position = new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// @Author : Veli-Matti Vuoti
/// 
/// This class is For Elevator
/// Some stypid representation of door opening, changed to run Animation of door open!
/// </summary>
public class ElevatorDoorHandler : MonoBehaviour
{
    public Vector3 door1start;
    public Vector3 door2start;
    public Vector3 door1end;
    public Vector3 door2end;
    public float time = 1f;
    public Transform [] doors;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player is near doors!");
            OpenDoors();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player moved away from doors!");
            CloseDoors();
        }
    }

    /// <summary>
    /// TODO: Change this function to activate door open animation.
    /// </summary>
    public void OpenDoors()
    {
        door1start = doors[0].position;
        door2start = doors[1].position;
        door1end = doors[0].position + Vector3.left * -1.5f;
        door2end = doors[1].position + Vector3.left * 1.5f;
        doors[0].position = Vector3.Lerp(door1start, door1end, time);
        doors[1].position = Vector3.Lerp(door2start, door2end, time);
    }

    /// <summary>
    /// TODO: Change this function to activate door closing animation.
    /// </summary>
    public void CloseDoors()
    {
        doors[0].position = Vector3.Lerp(door1end, door1start, time);
        doors[1].position = Vector3.Lerp(door2end, door2start, time);
    }

}
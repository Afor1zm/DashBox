using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierCollisionDetection : MonoBehaviour
{
    public static Action OnCollided;
    private void OnTriggerEnter2D(Collider2D other)
    {        
        if (other.gameObject.GetComponent<PlayerMoving>() != null)
        {
            OnCollided?.Invoke();
        }
    }
}
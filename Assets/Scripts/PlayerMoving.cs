using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector3 _vector3 = new Vector3();

   
    void Start()
    {
        _vector3.x = _speed;        
    }

    void FixedUpdate()
    {
        transform.position +=  _vector3;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [HideInInspector]
    public string ChararcterStatus = "Idle";
    [Header("Personal stats")]
    [SerializeField] private int _maximumHP;
    [SerializeField] private int _minimumHP;
    private int currentHp;
    [Header("Personal properties")]
    [SerializeField][Range(1,7)] private int _damage;
    [SerializeField][Range(0.5f, 17.3f)] [Space] private float _velocity;

    private void Start()
    {
        Debug.Log(currentHp);
    }

}

using System;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SegmentConstructor: MonoBehaviour
{
    [SerializeField] private GameObject _segment1;
    [SerializeField] private GameObject _segment2;
    [SerializeField] private GameObject _segment3;
    [SerializeField] private GameObject _segment4;   
    [SerializeField] private int _segments;
    private float _randomValue;
    private int _segmentLength = 4;

    private void Start()
    {
        for (int i = 0; i < _segments; i++)
        {
            CreateSegment(i);
        }        
    }

    private void CreateSegment(int segmentNumber)
    {        
        _randomValue = Random.Range(1, 5);
        switch (_randomValue)
        {
            case(1):
                Instantiate(_segment1, new Vector2(segmentNumber*_segmentLength, 2), quaternion.identity);                
                break;
            case(2):
                Instantiate(_segment2, new Vector2(segmentNumber*_segmentLength, 2), quaternion.identity); 
                break;
            case(3):
                Instantiate(_segment3, new Vector2(segmentNumber*_segmentLength, 2), quaternion.identity); 
                break;
            case(4):
                Instantiate(_segment4, new Vector2(segmentNumber*_segmentLength, 2), quaternion.identity); 
                break;
        }      
    }
}
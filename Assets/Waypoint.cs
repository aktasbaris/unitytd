using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] GameObject tower;
    [SerializeField] bool isPlaceable;

    void OnMouseDown()
    {
        if (isPlaceable)
        {
            Instantiate(tower, transform.position, Quaternion.identity);
            isPlaceable = false;
        }
    }
}

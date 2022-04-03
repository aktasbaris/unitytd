using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeter : MonoBehaviour
{
    [SerializeField] Transform weapon;
    Transform target;

    void Start()
    {
        target = FindObjectOfType<Enemy>().transform;
    }

    void Update()
    {
        weapon.LookAt(target);
    }
}

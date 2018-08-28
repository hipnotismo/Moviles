using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private float range;

	void Update ()
    {
        RaycastHit hitInfo;
        bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, range);

        if (hit)
        {

        }
	}
}

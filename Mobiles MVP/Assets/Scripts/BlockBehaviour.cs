using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour {

    [SerializeField] GameObject[] barrs;
    [SerializeField] private float health;
    float totalHealth;
    int pos;

    private void Awake()
    {
        totalHealth = health;
    }

    void Update ()
    {
        if (health <= totalHealth - totalHealth / 3)
        {
            barrs[pos].SetActive(false);
            pos++;
            totalHealth -= totalHealth / 3;
        }
	}
}

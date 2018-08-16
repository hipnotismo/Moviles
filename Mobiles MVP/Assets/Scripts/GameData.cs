using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {

    [SerializeField] private GameObject player;
    private Vector3 plyPos;

    public Vector3 PlyPos
    {
        get
        {
            return plyPos;
        }
    }

    void Awake ()
    {
        plyPos = player.transform.position;
	}

    private void Update()
    {
        if (plyPos != player.transform.position)
            plyPos = player.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform character;
    public float y = 2f;
    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        transform.position = new Vector3(character.position.x, character.position.y + y, -10);
    }
}

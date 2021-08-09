using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    Rigidbody2D rgb;

    float speed = 5f;
    float jump = 9f;

    void Start()
    {
        rgb = GetComponent < Rigidbody2D>();
    }

    void Update()
    {
        Vector3 velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speed * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rgb.velocity.y, 0))
        {
            rgb.AddForce(Vector3.up * jump, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Heals"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("End"))
        {
            HeartControl.instance.gameWin.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

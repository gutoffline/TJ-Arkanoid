using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 10.0f;
    public float horizontalAxis;
    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalAxis * velocidade, 0);
    }
}

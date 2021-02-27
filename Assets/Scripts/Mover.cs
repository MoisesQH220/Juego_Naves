using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector3 direction;
    public float speed;

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    // Start is called before the first frame update
    public void DoMove(Vector3 moverValue)
    {
        transform.Translate(moverValue);
    }
}

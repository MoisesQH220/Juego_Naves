using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMinimum, xMaximum, yMinimum, yMaximum;
}

public class PlayerController : MonoBehaviour
{
    public Mover moverComponent;
    public float speed;
    public Boundary boundary;

    public Transform shootOrigin;
    public GameObject shootPrefab;

    public Mover MoverComponent { get => moverComponent; set => moverComponent = value; }

    // Start is called before the first frame update
    void Start()
    {
        moverComponent.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 desplazamiento = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime,
            Input.GetAxis("Vertical") * speed * Time.deltaTime, transform.position.z);
        moverComponent.DoMove(desplazamiento);

        float x = Mathf.Clamp(transform.position.x, boundary.xMinimum, boundary.xMaximum);
        float y = Mathf.Clamp(transform.position.y, boundary.yMinimum, boundary.yMaximum);
        transform.position = new Vector3(x, y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shootPrefab, shootOrigin, false);
        }
    }
}

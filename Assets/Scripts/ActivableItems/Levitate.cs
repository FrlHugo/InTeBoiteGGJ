using UnityEngine;

public class Levitate : MonoBehaviour
{
    public float speedMin = 1.0f;
    public float speedMax = 5.0f;
    public float Maxsize = 0.2f;

    private float speed;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
        speed = Random.Range(speedMin, speedMax);
    }

    void Update()
    {
        float y = Mathf.Sin(Time.time * speed);
        transform.position = startPos + new Vector3(0, y*Maxsize, 0);
    }
}

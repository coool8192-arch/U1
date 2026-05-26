using UnityEngine;

public class Character : MonoBehaviour
{
    public Vector3 direction;
    void Start()
    {

    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        transform.position += direction;
    }
}

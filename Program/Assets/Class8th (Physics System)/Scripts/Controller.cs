using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Vector3 direction;
    [SerializeField] float speed;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");
        direction.Normalize();

        transform.position += direction * Time.deltaTime;
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(direction * speed, ForceMode.Force);
    }
}

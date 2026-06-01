using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Vector3 direction;
    [SerializeField] float force;
    [SerializeField] ForceMode forceMode;

    void Start()
    {
        forceMode = ForceMode.Force;

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
        if (forceMode == ForceMode.Impulse)
        {
            rigidbody.AddForce(Vector3.up * force, ForceMode.Impulse);

            forceMode = ForceMode.Force;

            return;
        }

        rigidbody.AddForce(direction * force, ForceMode.Force);
    }

    public void Soar()
    {
        forceMode = ForceMode.Impulse;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Barrier")) 
        {
             Debug.Log("OnCollisionEnter");
        }
    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }
    void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }

}

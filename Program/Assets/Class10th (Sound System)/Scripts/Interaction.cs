using System.Linq;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] Ray ray;

    void Start()
    {
        
    }

    void Update()
    {
    }

    void OnDrawGizmos()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Gizmos.DrawRay(ray.origin, ray.direction * 100);
    }
}

using System.Linq;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit raycastHit;
    [SerializeField] LayerMask layerMask;
    [SerializeField] float distance = 100.0f;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit, distance, layerMask)) 
            {
                AudioSource audioSource = raycastHit.collider.GetComponent<AudioSource>();

                if (audioSource.isPlaying == false)
                {
                    audioSource.Play();
                }
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawRay(ray.origin, ray.direction * 100);
    }
}

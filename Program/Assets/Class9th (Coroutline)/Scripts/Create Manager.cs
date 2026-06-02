using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject elemental;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject gameObject = Instantiate(elemental, transform);

            gameObject.transform.position = new Vector3(i * 1.5f - 3, 0, 0);
        }
    }

    void Update()
    {

    }
}

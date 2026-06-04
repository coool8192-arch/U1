using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject elemental;
    [SerializeField] List<GameObject> list;
    public float intervalTime = 5.0f;
    int count;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject gameObject = Instantiate(elemental, transform);

            gameObject.transform.position = new Vector3(i * 1.5f - 3, 0, 0);

            gameObject.SetActive(false);

            list.Add(gameObject);
        }

        StartCoroutine(Coroutine());
    }

    IEnumerator Coroutine()
    {
        WaitForSeconds wait = new WaitForSeconds(intervalTime);

        while (count < list.Count)
        {
            list[count++].SetActive(true);

            yield return wait;
        }
    }

    void Update()
    {

    }
}

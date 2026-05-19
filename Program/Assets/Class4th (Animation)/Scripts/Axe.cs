using UnityEngine;

public class Axe : MonoBehaviour
{
    public void Attack(int count)
    {
        if (count >= 10)
        {
            Debug.Log("Crtical Hit");

            count = 0;
        }
    }
}

using UnityEngine;

public class Axe : MonoBehaviour
{
    public int hit;
    public float proficiency;

    public void Attack(int count)
    {
         hit += count;

        if ( hit % 10 == 0)
        {
            Debug.Log("Crtical Hit");
        }
    }

    public void Throw(float experience)
    {
        if (proficiency >= 100)
        {
            Debug.Log("Critical hit");

            return;
        } 

        proficiency += experience;

    }
}

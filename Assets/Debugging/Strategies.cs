using UnityEngine;

public class Strategies : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        //loop ten times
        for (int i = 0; i < 10; i++)
        {
            //instantiate a prefab
            //at a x position that's increasing by 1
            //and a y position that's increasing by 0.1
            //and 0 in z, no rotation

            float x = i; //this shouldn't be 0 !!

            // 0/10 = 0
            // 1/10 = 0.1
            // 2/10 = 0.2
            Debug.Log(i + "/" + 10 + " = " + i / 10f);
            float y = i / 10f; //this shouldn't be 0 !!
            Debug.Log("Y = " + y);

            float z = 0; //this one is fine

            Instantiate(prefab, new Vector3 (x, y, z), Quaternion.identity);
        }
    }

}

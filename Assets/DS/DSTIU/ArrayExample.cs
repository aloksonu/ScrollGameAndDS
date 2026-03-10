using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // Array Declaration and Initialization
    int[] number = { 10, 20, 30, 40, 50, 60, 70 };
    string[] sNames = { "John", "Cena" , "Alok"};
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Showing the array  // By For Loop
        //for (int i = 0; i < number.Length; i++)
        //{
        //    Debug.Log(number[i]);
        //}

        // Showing the array  // By Foreach Loop
        //foreach (int i in number)
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 0; i < sNames.Length; i++)
        //{
        //    Debug.Log(sNames[i]);
        //}

        foreach (string i in sNames)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

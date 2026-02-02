using UnityEngine;

public class OneDArray : MonoBehaviour
{

    // Array is collection of similar type of data

    // Delclare of Variabe
    int amount;
    string name;

    // Delclare of Array
    int[] amounts = new int[5];
    string[] names = new string[5];

    // initialization and declaration
    int[] number = { 10, 20, 30, 40, 50, 60, 70 };
    string[] sNames = { "John", "Cena" };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialization of Variale
        amount = 10;
        name = "ParthMyWife";

        // Initialization of Array
        amounts[0] = 10;
        amounts[1] = 20;
        amounts[2] = 30;
        amounts[3] = 20;
        amounts[4] = 30;

        names[0] = "Johnny";
        names[1] = "Raja";
        names[2] = "Babu";
        names[3] = "Albert";
        names[4] = "Einstein";

        // Debug.Log(amount);
        //Debug.Log(amounts[0]);
        //Debug.Log(amounts[1]);
        //Debug.Log(amounts[2]);
        //Debug.Log(amounts[3]);
        //Debug.Log(amounts[4]);

        //Debug.Log(number[0]);
        //Debug.Log(number[1]);
        //Debug.Log(number[2]);
        //Debug.Log(number[3]);
        //Debug.Log(number[4]);

        //for(int i = 0; i < number.Length; i++)
        //{
        //    Debug.Log(number[i]);
        //}

        //foreach(int i in amounts)
        //{
        //    Debug.Log(i);
        //}

        //for (int i = 0; i< sNames.Length; i++)
        //{
        //    Debug.Log(sNames[i]);
        //}

        foreach(string i in names)
        {
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

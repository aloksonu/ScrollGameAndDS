using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class TwoDArrayExample1 : MonoBehaviour
{
    // Declare
    int[,] marks;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Initialize
        // 3 Rows, 3 Columns
        marks = new int[3, 3]
        {
          //Col1 Col2 Col3
            { 80, 75, 90 }, // Row1
            { 60, 85, 70 }, // Row2
            { 88, 92, 78 }  // Row3
        };


        // Print all values
        //for (int row = 0; row < 3; row++)
        //{
        //    for (int col = 0; col < 3; col++)
        //    {
        //        Debug.Log("Marks[" + row + "," + col + "] = " + marks[row, col]);
        //    }
        //}

        Debug.Log(marks[1, 0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

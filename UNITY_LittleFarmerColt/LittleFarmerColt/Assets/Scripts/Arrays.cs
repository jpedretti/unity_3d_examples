using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour
{

    private int[,] _pigletArray = new int[10, 3];
    private int[,] _pigArray = new int[10, 3];
    private int[,] _chickArray = new int[10, 3];
    private int[,] _chickenArray = new int[10, 3];

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            // piglet array initial values
            _pigletArray[i, 0] = 1; // visible : 0=no; 1=yes
            _pigletArray[i, 1] = 0; //corn
            _pigletArray[i, 2] = 0; //water

            // pig array initial values
            _pigArray[i, 0] = 0; // visible : 0=no; 1=yes
            _pigArray[i, 1] = 0; //corn
            _pigArray[i, 2] = 0; //water 

            // piglet array initial values
            _chickArray[i, 0] = 1; // visible : 0=no; 1=yes
            _chickArray[i, 1] = 0; //corn
            _chickArray[i, 2] = 0; //water

            // piglet array initial values
            _chickenArray[i, 0] = 0; // visible : 0=no; 1=yes
            _chickenArray[i, 1] = 0; //corn
            _chickenArray[i, 2] = 0; //water
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

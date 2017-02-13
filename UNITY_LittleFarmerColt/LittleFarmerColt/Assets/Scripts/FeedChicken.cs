using UnityEngine;
using System.Collections;

public class FeedChicken : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (GameData.Water > 0)
        {
            GameData.Water--;
            //add water to chicken's holdings
        }

        if (GameData.Corn > 0)
        {
            GameData.Corn--;
            //add conr to cheken's holdins
        }
    }
}

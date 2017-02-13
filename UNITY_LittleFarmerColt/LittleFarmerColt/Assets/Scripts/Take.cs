using UnityEngine;
using System.Collections;

public class Take : MonoBehaviour
{

    private Animator _animator;
    private int _takeHash = Animator.StringToHash("Take");
    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            _animator.Play(_takeHash);
            GameData.Water++;
            Debug.Log(GameData.Water);
        }
    }
}

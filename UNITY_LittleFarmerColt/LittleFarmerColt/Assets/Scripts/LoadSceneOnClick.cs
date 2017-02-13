using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{

    public void LoadScene(int scene)
    {
        SceneManager.LoadSceneAsync(scene);
    }
}

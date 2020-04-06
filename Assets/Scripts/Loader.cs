using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{

    public ItemData MyData;

    void Start()
    {
        Debug.Log(MyData.ItemName + " " + UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SceneA");
        }

        if(Input.GetKeyDown(KeyCode.W)){
            UnityEngine.SceneManagement.SceneManager.LoadScene("SceneB");
        }
    }

}

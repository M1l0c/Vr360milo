using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    // Start is called before the first frame update

    public void SceneSeleccion(string sala)
    {

        if (sala == "sala2")
        {
            SceneManager.LoadScene("sala2");

        }

        else if (sala=="sala1")
        {
            SceneManager.LoadScene("sala1");
            }
        else if (sala == "sala3")
        {
            SceneManager.LoadScene("sala3");
        }
    }


    void start()
{

}

    // Update is called once per frame
    void Update()
    {
        
    }
}

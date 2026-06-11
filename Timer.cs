using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float seconds;
    public int minutes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                minutes--;
                seconds = 59;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                EditorSceneManager.LoadScene(sceneIndex);
            }
        }
    }
}

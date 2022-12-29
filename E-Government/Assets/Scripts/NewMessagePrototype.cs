using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMessagePrototype : MonoBehaviour
{
    string SceneName = "NewMessagePrototypeScene";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(SceneName);
        Destroy(gameObject);
    }
}

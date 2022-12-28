using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewDocumentPrototype : MonoBehaviour
{
    public int Id = 0;
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
    }
}

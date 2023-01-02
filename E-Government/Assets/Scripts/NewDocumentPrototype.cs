using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//Script to detect mouse click on Document file type
public class NewDocumentPrototype : MonoBehaviour
{
    public string SceneName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Load document scene on click
    private void OnMouseDown()
    {
        SceneManager.LoadScene(SceneName);
    }
}

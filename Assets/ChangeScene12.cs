using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene12 : MonoBehaviour
{
    // Start is called before the first frame update
    // public string scenename;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change(){
        
        SceneManager.LoadScene("earthScene");
    }
}

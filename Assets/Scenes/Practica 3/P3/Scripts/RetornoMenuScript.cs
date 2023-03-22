using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetornoMenuScript : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    public void OnPointerEnter()
    {

    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {

    }

    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public void OnPointerClick()
    {
        SceneManager.LoadScene(name);
    }
}

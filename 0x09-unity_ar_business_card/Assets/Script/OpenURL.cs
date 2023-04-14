using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LinkedIn()
    {
        Application.OpenURL("https://www.Linkedin.com/in/dev-jesus-junco/");
    }

    public void GitHub()
    {
        Application.OpenURL("github.com/bcondict");
    }

    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/10night_mare07");
    }

    public void Email()
    {
        Application.OpenURL("mailto:jesus.junc10@gmail.com");
    }
}

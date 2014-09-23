using UnityEngine;
using System.Collections;

public class restart_btn : MonoBehaviour {


    public void restartLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}

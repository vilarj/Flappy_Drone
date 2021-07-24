using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Singleton part
    private static GameManager _instance = null;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }

    public static GameManager instance()
    {
        return _instance;
    }


}

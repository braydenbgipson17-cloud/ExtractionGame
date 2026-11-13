using UnityEngine;

public class Player : MonoBehaviour
{

    private static Player _instance;

    private void Awake()
    {
        if(_instance != null) { Destroy(gameObject); return; }
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }
   
}

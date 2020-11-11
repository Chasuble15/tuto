using UnityEngine;

public class DontDestroyOnLoadScreen : MonoBehaviour
{
    public GameObject[] objects;
    void Awake()
    {
       foreach (var element in objects)
        {
            DontDestroyOnLoad(element);
        } 
    }
}

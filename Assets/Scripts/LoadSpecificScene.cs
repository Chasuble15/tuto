using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSpecificScene : MonoBehaviour
{
    public string sceneName;
    [HideInInspector] public Animator fade;

    private void Awake()
    {
        fade = GameObject.FindGameObjectWithTag("FadeSystem").GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine("loadNextLevel");
        }
    }

    public IEnumerator loadNextLevel()
    {
        fade.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneName);
    }
}

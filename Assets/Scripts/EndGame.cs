using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame: MonoBehaviour
{
    [SerializeField] private GameObject _endGameScreen;

    private void Awake()
    {
        BarrierCollisionDetection.OnCollided += ShowEndGamePanel;
        Time.timeScale = 1;
    }

    private void ShowEndGamePanel()
    {
        Time.timeScale = 0;
        _endGameScreen.SetActive(true);
    }

    private IEnumerator LoadMain(string sceneName)
    {
        AsyncOperation asyncLoad =
            SceneManager.LoadSceneAsync(sceneName, new LoadSceneParameters(LoadSceneMode.Single));            
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void LoadScene()
    {        
        BarrierCollisionDetection.OnCollided -= ShowEndGamePanel;
        StartCoroutine(LoadMain("SampleScene"));            
    }

}
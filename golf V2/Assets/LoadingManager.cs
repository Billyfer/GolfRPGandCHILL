using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Progress());
    }
    IEnumerator Progress()
    {
        yield return new WaitForSeconds(1);
        var asyncOp = SceneManager.LoadSceneAsync(SceneLoader.SceneToLoad);

        while (asyncOp.isDone == false)
        {
            Debug.Log(asyncOp.progress * 100);
            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Failure_collider : MonoBehaviour
{
    [SerializeField] float timeToWait = 2.5f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            StartCoroutine(ProcessFailure());
        }
    }

    private IEnumerator ProcessFailure()
    {
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene("Test_Scene");
    }
}

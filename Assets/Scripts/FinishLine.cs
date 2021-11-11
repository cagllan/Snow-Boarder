using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      // Debug.Log("You finished");
      SceneManager.LoadScene(0);
    }

  }
}

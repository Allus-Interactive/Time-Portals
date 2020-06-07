using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectableController : MonoBehaviour
{
    private AudioSource collectableSFX;

    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.CompareTag("Collectable"))
                {
                    collectableSFX = GetComponent<AudioSource>();
                    collectableSFX.Play();
                    gameObject.SetActive(false);
                    SceneManager.LoadScene(1);
                }
            }
        }
    }
}

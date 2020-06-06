using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableContainer : MonoBehaviour
{
    // private AudioSource collectableSFX;

    void Awake()
    {
        // collectableSFX = GetComponent<AudioSource>();
    }

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
                    gameObject.SetActive(false);
                    // collectableSFX.Play();
                }
            }
        }
    }
}

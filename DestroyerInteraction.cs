using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Interaction
{

    public class DestroyerInteraction : MonoBehaviour
    {

        void OnCollisionEnter2D(Collision2D col)
        {
            if (col.gameObject.tag == "pointTag" || col.gameObject.tag == "bugTag")
                Destroy(col.gameObject);
        }
        
    }
}

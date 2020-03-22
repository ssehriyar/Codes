using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnBug : MonoBehaviour
{
    //public Text text;
    public GameObject bug = null;
    protected GameObject objBug;
    float rand1, rand2, rand3, rand4;
    int rand;
    float waitTime = 10.0f;
    float time = 0.0f;
    float realTime = 0.0f;
    // Start is called before the first frame update

    void Update()
    {
        realTime += Time.deltaTime;
        time += Time.deltaTime;
        //text.text = time + "   " + waitTime.ToString() + "   " + realTime;
        if (time > waitTime)
        {
            if (((int)realTime % 8 == 0.0f) && waitTime > 1.5f)
            {
                waitTime -= 0.5f;
            }

            rand = Random.Range(1, 5);
            switch (rand)
            {
                case 1:
                    rand1 = Random.Range(-8.5f, 8.5f);
                    objBug = Instantiate(bug, new Vector3(rand1, 6, 0), Quaternion.identity);
                    objBug.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -280));
                    break;
                case 2:
                    rand2 = Random.Range(-4f, 4f);
                    objBug = Instantiate(bug, new Vector3(11, rand2, 0), Quaternion.identity);
                    objBug.GetComponent<Rigidbody2D>().AddForce(new Vector2(-280, 0));
                    break;
                case 3:
                    rand3 = Random.Range(-8.5f, 8.5f);
                    objBug = Instantiate(bug, new Vector3(rand3, -6, 0), Quaternion.identity);
                    objBug.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 280));
                    break;
                case 4:
                    rand4 = Random.Range(-4f, 4f);
                    objBug = Instantiate(bug, new Vector3(-11, rand4, 0), Quaternion.identity);
                    objBug.GetComponent<Rigidbody2D>().AddForce(new Vector2(280, 0));
                    break;
                default:
                    break;
            }
            time = 0;
        }

    }
}


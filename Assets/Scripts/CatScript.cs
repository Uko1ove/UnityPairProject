using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    private AudioSource audio1;
    public int cat_speed = 10;

    private void Start()
    {
        audio1 = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * cat_speed);
        Ray ray1 = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray1, 2))
        {
            audio1.Play();

            if (Random.RandomRange(0, 2) == 0)
                transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y + 90, 0);
            else
                transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y - 90, 0);
        }
    }
}

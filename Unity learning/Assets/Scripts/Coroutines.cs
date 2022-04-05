using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Coroutines : MonoBehaviour
    {
        Material m_Material;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("f"))
            {
                StartCoroutine(Fade());
            }
        }

        IEnumerator Fade()
        {
            m_Material = GetComponent<Renderer>().material;
            Color c = m_Material.color;
            for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
            {             
                c.a = alpha;
                m_Material.color = c;
                Debug.Log(c);
                yield return new WaitForSeconds(.1f);
            }
        }
    }
}
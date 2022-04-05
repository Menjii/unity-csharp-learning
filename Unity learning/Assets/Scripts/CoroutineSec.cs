using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class CoroutineSec : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            StartCoroutine(coroutineA());
        }

        IEnumerator coroutineA()
        {
            // wait for 1 second
            Debug.Log("coroutineA created");
            yield return new WaitForSeconds(1.0f);
            yield return StartCoroutine(coroutineB());
            Debug.Log("coroutineA running again");
        }

        IEnumerator coroutineB()
        {
            Debug.Log("coroutineB created");
            yield return new WaitForSeconds(2.5f);
            Debug.Log("coroutineB enables coroutineA to run");
        }
    }
}
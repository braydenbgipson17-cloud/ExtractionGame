using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtractionCheck : MonoBehaviour
{
    [SerializeField] private float _extractionTimer;

    private Coroutine _extractCoroutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Player>(out Player p))
        {
            _extractCoroutine = StartCoroutine(ExtractionTimer());
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(_extractCoroutine != null)
        {
            StopCoroutine(_extractCoroutine);
            _extractCoroutine = null;
        }
    }

    IEnumerator ExtractionTimer()
    {
        float timeLeft = _extractionTimer;
        while(timeLeft > 0)
        {
            Debug.Log($"Extracting in {timeLeft}");
            yield return new WaitForSeconds(1f);
            timeLeft--;
        }
        SceneManager.LoadScene("OutlandsHub");
    }
}

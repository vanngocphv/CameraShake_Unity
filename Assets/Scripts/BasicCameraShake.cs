using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCameraShake : MonoBehaviour
{
    
    public IEnumerator ShakeCamera(float pTotalDuration, float pMagnitude)
    {
        //store base position
        Vector3 basePosition = this.transform.localPosition;

        float currentTime = 0;
        while (currentTime < pTotalDuration)
        {
            float xPosition = Random.Range(-1f, 1f) * pMagnitude;
            float yPosition = Random.Range(-1f, 1f) * pMagnitude;

            this.transform.localPosition = new Vector3(xPosition, yPosition, basePosition.z);

            currentTime += Time.deltaTime;
            yield return null;
        }

        this.transform.localPosition = basePosition;

        
    }
}

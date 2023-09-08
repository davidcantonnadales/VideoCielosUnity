using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSky : MonoBehaviour
{
    public List<Material> Cubemaps;

    void Start()
    {
        StartCoroutine(ChangeCubemap());
    }

    private IEnumerator ChangeCubemap()
    {
        var index  = 0;

        do
        {
            var cubemap = Cubemaps[index];
            RenderSettings.skybox = cubemap;
            DynamicGI.UpdateEnvironment();

            yield return new WaitForSeconds(2f);
            index++;

            if (index == Cubemaps.Count)
                index = 0;
        }while (true);
    }
}

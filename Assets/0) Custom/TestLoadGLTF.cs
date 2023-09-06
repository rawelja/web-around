using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoadGLTF : MonoBehaviour
{
    public string modelUrl = "https://echo.ix42.com/stegosaur.glb";
    public void LoadModelTest()
    {
        var gltf = gameObject.AddComponent<GLTFast.GltfAsset>();
        //gltf.Url = "https://echo.ix42.com/stegosaurs_SStenops.gltf";
        gltf.Url = modelUrl;
    }
}

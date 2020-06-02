using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateProjectFolders : MonoBehaviour
{

    [MenuItem("Tools/Create Project Folders")]
    static void CreateAllProjectFolders()
    {
        string guid = AssetDatabase.CreateFolder("Assets", "Scripts");
        string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);

        guid = AssetDatabase.CreateFolder("Assets", "Textures");
        newFolderPath = AssetDatabase.GUIDToAssetPath(guid);

        guid = AssetDatabase.CreateFolder("Assets", "Anims");
        newFolderPath = AssetDatabase.GUIDToAssetPath(guid);

        guid = AssetDatabase.CreateFolder("Assets", "Models");
        newFolderPath = AssetDatabase.GUIDToAssetPath(guid);

        guid = AssetDatabase.CreateFolder("Assets", "Audio");
        newFolderPath = AssetDatabase.GUIDToAssetPath(guid);

        guid = AssetDatabase.CreateFolder("Assets", "Fonts");
        newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
    }

   
}

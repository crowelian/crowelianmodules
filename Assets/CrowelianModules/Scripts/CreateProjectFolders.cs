using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateProjectFolders : MonoBehaviour
{

    [MenuItem("Tools/Create Project Folders")]
    static void CreateAllProjectFolders()
    {
        string guid = "";
        string newFolderPath = "";
        string createdFolders = "";

        if (!AssetDatabase.IsValidFolder("Assets/Scripts"))
        {
            guid = AssetDatabase.CreateFolder("Assets", "Scripts");
            newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
            createdFolders += "Scripts, ";
        }

        if (!AssetDatabase.IsValidFolder("Assets/Textures"))
        {
            guid = AssetDatabase.CreateFolder("Assets", "Textures");
            newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
            createdFolders += "Textures, ";
        }

        if (!AssetDatabase.IsValidFolder("Assets/Anims"))
        {
            guid = AssetDatabase.CreateFolder("Assets", "Anims");
            newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
            createdFolders += "Anims, ";
        }

        if (!AssetDatabase.IsValidFolder("Assets/Models"))
        {
            guid = AssetDatabase.CreateFolder("Assets", "Models");
            newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
            createdFolders += "Models, ";
        }

        if (!AssetDatabase.IsValidFolder("Assets/Audio"))
        {
            guid = AssetDatabase.CreateFolder("Assets", "Audio");
            newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
            createdFolders += "Audio, ";
        }

        if (!AssetDatabase.IsValidFolder("Assets/Fonts"))
        {
            guid = AssetDatabase.CreateFolder("Assets", "Fonts");
            newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
            createdFolders += "Fonts, ";
        }
        
        

        if (guid == "")
        {
            Debug.LogError("All folders already created!");
        } else
        {
            Debug.Log("Create Project folders... Done! \nFolders created: " + "<color=orange>" + createdFolders + "</color>");
        }
    }

   
}

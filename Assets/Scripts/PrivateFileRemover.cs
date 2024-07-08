<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PrivateFileRemover : MonoBehaviour
{
    public string filePath = "";
    
    public List<string> privatefiles = new List<string>();

    private void Reset()
    {
        filePath = Application.dataPath;
        var path = filePath.Split("Assets");
        Debug.Log("file path: "+ path[0]);
    }

    [ContextMenu("Get Path")]
    void GetPaths()
    {
        privatefiles.Clear();

        var files = Directory.GetFiles(filePath, "*.private.0", SearchOption.AllDirectories);
        foreach (var file in files) 
        {
            if (file.Contains(".private.0"))
            {
                privatefiles.Add(file);
            }
        }
    }

    [ContextMenu("Private File Remove")]
    void RemovePrivateFile()
    {
        foreach (var file in privatefiles)
        {
           File.Delete(file);
        }
    }

}
=======
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PrivateFileRemover : MonoBehaviour
{
    public string filePath = "";
    
    public List<string> privatefiles = new List<string>();

    private void Reset()
    {
        filePath = Application.dataPath;
        var path = filePath.Split("Assets");
        Debug.Log("file path: "+ path[0]);
    }

    [ContextMenu("Get Path")]
    void GetPaths()
    {
        privatefiles.Clear();

        var files = Directory.GetFiles(filePath, "*.private.0", SearchOption.AllDirectories);
        foreach (var file in files) 
        {
            if (file.Contains(".private.0"))
            {
                privatefiles.Add(file);
            }
        }
    }

    [ContextMenu("Private File Remove")]
    void RemovePrivateFile()
    {
        foreach (var file in privatefiles)
        {
           File.Delete(file);
        }
    }

}
>>>>>>> Stashed changes

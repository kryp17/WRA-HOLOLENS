using UnityEngine;
using UnityEditor;
using System.IO;

public class HandleTextFile
{
    [MenuItem("Tools/Write file")]
    //this first function vendam
    static void WriteString()
    {
        string path = "Assets/Resources/test.txt";

        //Write some text to the test.txt file.
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("Test");
        writer.Close();

        //Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path); 
        TextAsset asset = Resources.Load("test");

        //Print the text from the file
        Debug.Log(asset.text);
    }

    [MenuItem("Tools/Read file")]
    // try this one out. with your specific document directory.
    static void ReadString()
    {
        string path = "Assets/Resources/test.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path); 
        Debug.Log(reader.ReadToEnd());
        reader.Close();
    }

}

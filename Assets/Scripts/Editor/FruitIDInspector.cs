using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.UI;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

[CustomPropertyDrawer(typeof(FruitID))]
public class FruitIDInspector : PropertyDrawer
{
    SerializedProperty m_property;
    public override VisualElement CreatePropertyGUI(SerializedProperty property)
    {
        m_property = property;
        // Create a new VisualElement to be the root of our inspector UI
        VisualElement myInspector = new VisualElement();

        // Add a simple label
        FruitID fruitID = (FruitID)property.boxedValue;
        List<string> list = FruitIDList.instance.FruitIDs;
        int index = Mathf.Clamp(list.IndexOf(fruitID.ID), 0, list.Count - 1);
        DropdownField dropdownField = new DropdownField("FruitID", list, index);
        dropdownField.bindingPath = "ID";
        dropdownField.BindProperty(property.serializedObject);
        myInspector.Add(dropdownField);
        // Return the finished inspector UI
        return myInspector;
    }
}

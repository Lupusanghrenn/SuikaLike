using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

[CustomPropertyDrawer(typeof(FruitData))]
public class FruitDataPropertyDrawer : PropertyDrawer
{ 
    public override VisualElement CreatePropertyGUI(SerializedProperty property)
    {
        UnityEngine.UIElements.PopupWindow inspector = new UnityEngine.UIElements.PopupWindow();
        inspector.text = "Fruit Data";
        inspector.Add(new PropertyField(property.FindPropertyRelative("idName")));
        inspector.Add(new PropertyField(property.FindPropertyRelative("score")));
        inspector.Add(new PropertyField(property.FindPropertyRelative("gameObject")));

        return inspector;
    }
}

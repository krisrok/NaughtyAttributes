using UnityEngine;
using UnityEditor;

namespace NaughtyAttributes.Editor
{
	[CustomPropertyDrawer(typeof(AllowNestingAttribute))]
	public class AllowNestingPropertyDrawer : PropertyDrawerBase
	{
		protected override void OnGUI_Internal(Rect rect, SerializedProperty property, GUIContent label)
		{
			EditorGUI.BeginProperty(rect, label, property);
			EditorGUI.PropertyField(rect, property, label, true);
			EditorGUI.EndProperty();
		}

		protected override float GetPropertyHeight_Internal(SerializedProperty property, GUIContent label)
		{
			return EditorGUI.GetPropertyHeight(property, true);
		}
	}
}

using UnityEngine;
using System.Collections.Generic;

public static class GameObjectExtensions
{
    /// <summary>
    /// 指定されたインターフェイスを実装したコンポーネントを持つオブジェクトを検索します
    /// </summary>
    public static T FindObjectOfInterface<T>() where T : class
    {
        foreach ( var n in GameObject.FindObjectsOfType<Component>() )
        {
            var component = n as T;
            if ( component != null )
            {
                return component;
            }
        }
        return null;
    }
    
    public static T[] FindObjectOfInterfaces<T>() where T : class
    {
        List<T> list = new List<T>();
        foreach ( var n in GameObject.FindObjectsOfType<Component>() )
        {
            var component = n as T;
            if ( component != null )
            {
                list.Add (component);
            }
        }
        T[] ret = new T[list.Count];
        int count = 0;
        foreach (T component in list) {
            ret[count] = component;
            count++;
        }
        return ret;
    }
}
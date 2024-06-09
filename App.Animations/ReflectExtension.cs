using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace App.Animations
{
    internal static class ReflectExtension
    {
        //----------------------------------------------------------
        // Type
        //----------------------------------------------------------
        /// <summary>判断类是否是否个类或其子类</summary>
        public static bool IsType(this Type raw, string matchType)
        {
            Type type = raw;
            while (type != null)
            {
                if (type.FullName == matchType)
                    return true;
                type = type.BaseType;
            }
            return false;
        }



        //----------------------------------------------------------
        // Name
        //----------------------------------------------------------
        /// <summary>获取表达式名。GetName&lt;User&gt;(t =&gt; t.Dept.Name);</summary>
        public static string GetName<T>(Expression<Func<T, object>> expression)
        {
            return GetName(expression);
        }

        /// <summary>获取表达式名。GetName&lt;User&gt;(t =&gt; t.Dept.Name);</summary>
        public static string GetName(this Expression expr)
        {
            if (expr == null)
                return "";
            // Lambda 表达式
            if (expr is LambdaExpression le)
                return GetName(le.Body);
            // 一元操作符: array.Length, Convert(t.CreatDt)
            if (expr is UnaryExpression ue)
                return GetName((MemberExpression)ue.Operand);
            // 成员操作符： t.Dept.Name => body=t.Dept, member=Name
            if (expr is MemberExpression me)
            {
                var name = me.Member.Name;
                if (me.Expression is MemberExpression)
                    return GetName(me.Expression) + "." + name;
                else
                    return name;
            }
            // 参数本身：t 返回类型名
            if (expr is ParameterExpression pe)
                return pe.Type.Name;
            return "";
        }


        //----------------------------------------------------------
        // Property
        //----------------------------------------------------------
        public static PropertyInfo GetPropertyInfo<T, TValue>(this T obj, Expression<Func<T, TValue>> property)
        {
            return typeof(T).GetProperty(property.GetName());
        }

        /// <summary>获取对象的属性值。也可考虑用dynamic实现。</summary>
        /// <param name="propertyName">属性名。可考虑用nameof()表达式来实现强类型。</param>
        /// <param name="obj">any object</param>
        public static object GetPropertyValue(this object obj, string propertyName)
        {
            Type type = obj.GetType();
            PropertyInfo pi = type.GetProperty(propertyName);
            return pi.GetValue(obj);
        }



        //----------------------------------------------------------
        // Method
        //----------------------------------------------------------
        // 获取方法
        public static MethodInfo GetMethodInfo(this Type type, string methodName)
        {
            //MethodInfo info = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.IgnoreCase).FirstOrDefault();
            //return info;
            return type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.IgnoreCase).FirstOrDefault(t => t.Name == methodName);
        }


        // 调用方法
        public static object InvokeMethod(this object obj, MethodInfo info, object[] args)
        {
            return info.Invoke(obj, args);
        }
    }
}
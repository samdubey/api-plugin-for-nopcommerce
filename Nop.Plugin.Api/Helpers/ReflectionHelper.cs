﻿using System;
using System.Reflection;
using Newtonsoft.Json;

namespace Nop.Plugin.Api.Helpers
{
    public static class ReflectionHelper
    {
        public static bool HasProperty(string propertyName, Type type)
        {
            return type.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance) != null;
        }
        
        public static JsonObjectAttribute GetJsonObjectAttribute(Type objectType)
        {
            JsonObjectAttribute jsonObject = objectType.GetCustomAttribute(typeof(JsonObjectAttribute)) as JsonObjectAttribute;

            return jsonObject;
        }
    }
}
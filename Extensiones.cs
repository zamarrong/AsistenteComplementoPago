// Decompiled with JetBrains decompiler
// Type: AsistenteComplementoPago.Extensiones
// Assembly: AsistenteComplementoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1709CDC-0C8A-45BF-A0E1-9F7D768ECF51
// Assembly location: C:\Users\Jorge Zamarron\Pictures\AsistenteComplementoPago.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;

namespace AsistenteComplementoPago
{
  public static class Extensiones
  {
    public static bool Operator(this string logic, int x, int y)
    {
      string str = logic;
      if (str == ">")
        return x > y;
      if (str == ">=")
        return x >= y;
      if (str == "<")
        return x < y;
      if (str == "<=")
        return x <= y;
      if (str == "==")
        return x == y;
      throw new Exception("Lógica invalida");
    }

    public static void ClearChangeSet(this DataContext db)
    {
      ChangeSet changeSet = db.GetChangeSet();
      foreach (object insert in (IEnumerable<object>) changeSet.Inserts)
        db.GetTable(insert.GetType()).DeleteOnSubmit(insert);
      foreach (object delete in (IEnumerable<object>) changeSet.Deletes)
        db.GetTable(delete.GetType()).InsertOnSubmit(delete);
      db.Refresh(RefreshMode.OverwriteCurrentValues, (IEnumerable) changeSet.Updates);
    }

    public static List<T> DataTableToList<T>(this DataTable table) where T : class, new()
    {
      try
      {
        List<T> objList = new List<T>();
        foreach (DataRow row in (InternalDataCollectionBase) table.Rows)
        {
          T obj1 = new T();
          foreach (DataColumn column in (InternalDataCollectionBase) row.Table.Columns)
          {
            try
            {
              object obj2 = row[column.ColumnName];
              PropertyInfo property = obj1.GetType().GetProperty(column.ColumnName);
              if (property.PropertyType.IsEnum)
                property.SetValue((object) obj1, Convert.ChangeType(obj2, typeof (int)), (object[]) null);
              else
                property.SetValue((object) obj1, Convert.ChangeType(obj2, property.PropertyType), (object[]) null);
            }
            catch (Exception ex)
            {
            }
          }
          objList.Add(obj1);
        }
        return objList;
      }
      catch
      {
        return (List<T>) null;
      }
    }

    public static DataTable ToDataTable<T>(this IList<T> data)
    {
      PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof (T));
      DataTable dataTable = new DataTable();
      foreach (PropertyDescriptor propertyDescriptor in properties)
      {
        DataColumnCollection columns = dataTable.Columns;
        string name = propertyDescriptor.Name;
        Type type = Nullable.GetUnderlyingType(propertyDescriptor.PropertyType);
        if ((object) type == null)
          type = propertyDescriptor.PropertyType;
        columns.Add(name, type);
      }
      foreach (T obj in (IEnumerable<T>) data)
      {
        DataRow row = dataTable.NewRow();
        foreach (PropertyDescriptor propertyDescriptor in properties)
          row[propertyDescriptor.Name] = propertyDescriptor.GetValue((object) obj) ?? (object) DBNull.Value;
        dataTable.Rows.Add(row);
      }
      return dataTable;
    }

    public static void InitProperties(object obj)
    {
      foreach (PropertyInfo propertyInfo in ((IEnumerable<PropertyInfo>) obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (p => p.CanWrite)))
      {
        Type propertyType = propertyInfo.PropertyType;
        ConstructorInfo constructor = propertyType.GetConstructor(Type.EmptyTypes);
        if (propertyType.IsClass && constructor != (ConstructorInfo) null)
        {
          object instance = Activator.CreateInstance(propertyType);
          propertyInfo.SetValue(obj, instance, (object[]) null);
          Extensiones.InitProperties(instance);
        }
      }
    }

    public static bool IsNullOrEmpty(this object obj) => obj == null || string.IsNullOrWhiteSpace(obj.ToString());

    public static void CopyProperties(this object source, object destination)
    {
      Type type = source != null && destination != null ? destination.GetType() : throw new Exception("Source or/and Destination Objects are null");
      foreach (PropertyInfo property1 in source.GetType().GetProperties())
      {
        try
        {
          if (property1.CanRead)
          {
            PropertyInfo property2 = type.GetProperty(property1.Name);
            if (!(property2 == (PropertyInfo) null))
            {
              if (property2.CanWrite)
              {
                if (!(property2.GetSetMethod(true) != (MethodInfo) null) || !property2.GetSetMethod(true).IsPrivate)
                {
                  if ((uint) (property2.GetSetMethod().Attributes & MethodAttributes.Static) <= 0U)
                  {
                    if (property2.PropertyType.IsAssignableFrom(property1.PropertyType))
                    {
                      if (property2.GetValue(destination, (object[]) null) != property1.GetValue(source, (object[]) null))
                        property2.SetValue(destination, property1.GetValue(source, (object[]) null), (object[]) null);
                    }
                  }
                }
              }
            }
          }
        }
        catch
        {
        }
      }
    }

    public static string Serialize<T>(this T value)
    {
      if ((object) value == null)
        return string.Empty;
      try
      {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (T));
        StringWriter stringWriter = new StringWriter();
        using (XmlWriter xmlWriter = XmlWriter.Create((TextWriter) stringWriter))
        {
          xmlSerializer.Serialize(xmlWriter, (object) value);
          return stringWriter.ToString();
        }
      }
      catch (Exception ex)
      {
        return ex.Message;
      }
    }

    public static T[] RemoveFromArray<T>(this T[] original, T itemToRemove)
    {
      int index = Array.IndexOf<T>(original, itemToRemove);
      if (index == -1)
        return original;
      List<T> objList = new List<T>((IEnumerable<T>) original);
      objList.RemoveAt(index);
      return objList.ToArray();
    }
  }
}

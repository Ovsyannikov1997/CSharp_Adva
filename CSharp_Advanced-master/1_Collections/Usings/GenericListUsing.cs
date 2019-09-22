using System;
using System.Collections.Generic;

using ITEA_Collections.Common;

namespace ITEA_Collections.Usings
{
    internal class GenericListUsing : IBaseCollectionUsing
    {
        public List<string> List { get; set; }

        public GenericListUsing()
        {
            List = new List<string>();
        }

        public void Add(object ts)
        {
            List.Add(ts.ToString());
        }

        public void AddMany(object[] ts)
        {
            for (int i = 0; i < ts.Length; i++)
            {
                ts[i].ToString();
            }
            Console.WriteLine(ts[0].ToString());
            List.AddRange(ts);
       
        }

        public void Clear()
        {
            List.Clear();
        }

        public object[] GetAll()
        {
            return List.GetRange(0, List.Count).ToArray();
        }

        public object GetByID(int index)
        {
            throw new NotImplementedException();
        }

        public void RemoveByID(int index)
        {
            throw new NotImplementedException();
        }

        public void ShowAll()
        {
            throw new NotImplementedException();
        }
    }
}

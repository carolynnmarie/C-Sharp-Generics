using System;
using System.Collections.Generic;

namespace Generics{

    public class Generic<T> where T: IComparable{

        public T[] array {get; set;}

        public Generic(T[] array){
            this.array = array;
        }

        public Generic(){
            array = default(T[]);
        }

        public int countDuplicates(T[] a, T value){
            int x = 0;
            foreach(T item in a){
                if(item.Equals(value)) x++;
            }
            return x;
        }

        public int countDuplicatesInMerge(T[] values, T value){
            T[] genericArray = new T[values.Length + array.Length];
            array.CopyTo(genericArray,0);
            values.CopyTo(genericArray,array.Length);
            return countDuplicates(genericArray,value);
        }

         public T[] removeValue(T valueToRemove){
             int count = 0;
             int x = countDuplicates(array, valueToRemove);
             int y = array.Length;
             T[] removed = new T[y-x];
             foreach(var item in array){
                 if(!item.Equals(valueToRemove)){
                     removed[count] = item;
                     count++;
                 }
             }
             return removed;
        }

        public static K min<K>(List<K> list){
            K min = list[0];
            foreach(var x in list){
                if(Comparer<K>.Default.Compare(min,x)>0)
                min = x;
            }
            return min;
        }


        public static K max<K>(List<K> list){
            K max = list[0];
            foreach(var x in list){
                if(Comparer<K>.Default.Compare(max,x)<0) max = x;
            }
            return max;
        }

        public static K[] swap<K>(int i, int j, K[] values){
            K temp = values[i];
            values[i] = values[j];
            values[j] = temp;
            return values;
        }
    }
}
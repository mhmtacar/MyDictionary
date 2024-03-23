using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<Key,Value>
    {
        Key[] keys;
        Value[] values;

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            Key[] tempKeys = keys;
            Value[] tempValues = values;

            keys = new Key[keys.Length+1];
            values = new Value[values.Length+1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            keys[keys.Length-1] = key;
            values[values.Length-1] = value;

        }

        public Key[] Keys {
            get {  return keys; }
        }
        public Value[] Values
        {
            get { return values; }
        }
    }
}

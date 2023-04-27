using System.Collections.Generic;

namespace HashTables;

class HashTable<K, V>
{
    private const int INITIAL_CAPACITY = 16;
    private const float LOAD_FACTOR = .75f;

    //Each element in the table is a linked list of key-value pairs
    private LinkedList<KeyValuePair<K, V>>[] table;

    // The number of elements currently in the table.
    private int count;

    // The capacity of the table
    private int capacity;

    public HashTable() 
    {
        capacity = INITIAL_CAPACITY;
        table = new LinkedList<KeyValuePair<K, V>>[capacity];
        count = 0;
    }

    public void Add(K key, V value)
    {
        // If key is null, short-circuit
        if(key == null) throw new ArgumentNullException("key");

        // Calculate the hash code for the key
        int hashCode = key.GetHashCode();

        // Use the generated hash code to calculate the index in the array
        int index = hashCode % capacity;

        // If the linked list at the index is null, create a new one
        if (table[index] == null)
        {
            table[index] = new LinkedList<KeyValuePair<K, V>>();
        }

        // If the key already exists, update the value
        foreach(var pair in table[index])
        {
            if (pair.Key == null) continue;
            if (pair.Key.Equals(key))
            {
                pair.Value = value; ;
            }
        }


        
    }


}
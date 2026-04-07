using System.Collections;

namespace Proyecto4;

public class ColeccionPersonas : IList<Persona>
{
    private Persona[] _personas = null!;
    private int _count;

    public ColeccionPersonas()
    {
        _count = 0;
    }

    public ColeccionPersonas(Persona[] personas)
    {
        _personas = new Persona[personas.Length];
        for (int i = 0; i < personas.Length; i++)
        {
            _personas[i] = personas[i];
        }
        _count = _personas.Length;
    }
    
    public IEnumerator<Persona> GetEnumerator()
    {
        for (int i = 0; i < _count; i++)
        {
            yield return _personas[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(Persona item)
    {
        Insert(_count, item);
    }

    public void Clear()
    {
        _count = 0;
    }

    public bool Contains(Persona item)
    {
        bool encontrado = false;
        foreach (Persona persona in _personas)
        {
            if (persona.Equals(item))
            {
                encontrado = true;
                break;
            }
        }
        return encontrado;
    }

    public void CopyTo(Persona[] array, int arrayIndex)
    {
        int i =  arrayIndex;
        for (int j = 0; j < _count; j++)
        {
            array.SetValue(_personas[j], i);
            i++;
        }
    }

    public bool Remove(Persona item)
    {
        int index = IndexOf(item);
        RemoveAt(index);
        return index != -1;
    }

    public int Count { get { return _count; } }
    public bool IsReadOnly { get { return false; } }
    public int IndexOf(Persona item)
    {
        int index = 0;
        for (int i = 0; i < _count; i++)
        {
            if (_personas[i].Equals(item))
            {
                index = i;
                break;
            }
        }
        return index;
    }

    public void Insert(int index, Persona item)
    {
        if (index >= 0 && index <= _count)
        {
            Persona[] pTemporal = new Persona[_count];
            CopyTo(pTemporal, 0);
            _personas = new Persona[_count + 1];
            int posicionActual = 0;
            for (int i = 0; i < _count; i++)
            {
                if (i == index)
                {
                    _personas[posicionActual] = item;
                    posicionActual++;
                }
                else
                {
                    _personas[posicionActual] = pTemporal[i];
                    posicionActual++;
                }
            }
            if (index == _count)
            {
                _personas[_count] = item;
            }
            _count++;
        }
    }

    public void RemoveAt(int index)
    {
        if (index >= 0 && index < _count)
        {
            for (int i = index; i < _count;)
            {
                if (i == _count - 1)
                {
                    _personas[i] = null!;
                }
                else
                {
                    _personas[i] = _personas[i + 1];
                }
                _count--;
            }
        }
    }

    public Persona this[int index]
    {
        get
        {
            if (index >= 0 && index < _count)
            {
                return _personas[index];
            }
            else
            {
                return null!;
            }
        }
        set
        {
            if (index >= 0 && index < _count)
            {
                _personas[index] = value;
            }
        }
    }
}
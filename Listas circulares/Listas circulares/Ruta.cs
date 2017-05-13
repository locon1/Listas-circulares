using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_circulares
{
    class Ruta
    {
        private Base _inicio;
        private int _contador = 0;

        public void agregar(Base _base)
        {
            if (_inicio == null) 
            {
                _inicio = _base;
                _inicio.siguiente = _inicio;
            }
            else 
            {
                Base temp = _inicio;

                while (temp.siguiente != _inicio)
                    temp = temp.siguiente;

                _base.siguiente = _inicio;
                temp.siguiente = _base;
            }

            _contador++;
        }

        public void agregarInicio(Base _base)
        {
            if (_inicio == null) 
            {
                _inicio = _base;
                _inicio.siguiente = _inicio;
            }
            else if (_inicio.siguiente == _inicio) 
            {
                _base.siguiente = _inicio;
                _inicio.siguiente = _base;
                _inicio = _base;
            }
            else 
            {
                Base temp = _inicio;

                while (temp.siguiente != _inicio) 
                {
                    temp = temp.siguiente;
                }

                _base.siguiente = _inicio;
                temp.siguiente = _base;
                _inicio = _base;
            }

            _contador++;
        }

        public Base buscar(string nombre)
        {
            if (_inicio != null) 
            {
                if (nombre == _inicio.nombre) 
                {
                    return _inicio;
                }
                else 
                {
                    Base temp = _inicio.siguiente;

                    while (temp != _inicio) 
                    {
                        if (temp.nombre == nombre)
                            return temp;

                        temp = temp.siguiente;
                    }
                }
            }

            return null;
        }

        public void eliminar(string nombre)
        {
            if (_inicio != null) 
            {
                if (nombre == _inicio.nombre) 
                {
                    eliminarInicio();
                }
                else 
                {
                    Base temp = _inicio;

                    while (temp.siguiente != _inicio) 
                    {
                        if (temp.siguiente.nombre == nombre) 
                        {
                            temp.siguiente = temp.siguiente.siguiente;
                            _contador--;
                            break;
                        }

                        temp = temp.siguiente;
                    }
                }
            }
        }

        public void eliminarInicio()
        {
            if (_inicio != null) 
            {
                if (_inicio.siguiente == _inicio) 
                {
                    _inicio = null;
                }
                else 
                {
                    Base temp = _inicio.siguiente;

                    while (temp.siguiente != _inicio) 
                    {
                        temp = temp.siguiente;
                    }

                    temp.siguiente = temp.siguiente.siguiente;
                    _inicio = temp.siguiente;
                }

                _contador--;
            }
        }

        public void insertar(string nombre, Base _base)
        {
            if (_inicio != null) 
            {
                Base temp = _inicio;

                while (temp.siguiente != _inicio) 
                {
                    if (temp.nombre == nombre)
                        break;

                    temp = temp.siguiente;
                }

                if (temp.nombre == nombre) 
                {
                    _base.siguiente = temp.siguiente;
                    temp.siguiente = _base;
                    _contador++;
                }
            }
        }

        public override string ToString()
        {
            string salida = "Número de bases: " + _contador + Environment.NewLine;

            if (_inicio != null) 
            {
                salida += _inicio.ToString() + Environment.NewLine;
                Base temp = _inicio.siguiente;

                while (temp != _inicio) 
                {
                    salida += temp.ToString() + Environment.NewLine;
                    temp = temp.siguiente;
                }
            }

            return salida;
        }

        public string recorrido(string nombre, DateTime inicio, DateTime fin)
        {
            string salida = "";

            Base baseInicio = buscar(nombre);

            if (baseInicio != null && inicio <= fin) 
            {
                while (inicio <= fin) 
                {
                    salida += "Base: " + baseInicio.nombre.ToString() + Environment.NewLine;
                    salida += "Hora: " + inicio.ToString("HH:mm") + Environment.NewLine;
                    baseInicio = baseInicio.siguiente;
                    inicio = inicio.AddMinutes(baseInicio.minutos);
                }
            }
            else
                salida = "No se encontro la base o la hora de inicio ingresada es mayor o igual que la hora de fin";

            return salida;
        }
    }
}

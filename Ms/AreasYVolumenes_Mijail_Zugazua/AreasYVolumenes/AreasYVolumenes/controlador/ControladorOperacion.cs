using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AreasYVolumenes.modelo;

namespace AreasYVolumenes.controlador
{
    internal class ControladorOperacion
    {
        public double CalcularCirculo(double radio)
        {
            if(radio >0 && radio < 300)
            {
               Circulo circulo = new Circulo(radio);
            return circulo.AreaCirculo();
            }
            throw new Exception("No se puede calcular fuera del rango de 0 y 300");
          
        }

        public double CalcularEsfera(double radio)
        {
            if (radio > 0 && radio < 300)
            {
               Esfera esfera = new Esfera(radio);
            return esfera.VolumenEsfera(); 
            }
            throw new Exception("No se puede calcular fuera del rango de 0 y 300");
        }
        public double CalcularCubo(double lado)
        {
            if (lado > 0 && lado < 300)
            {
            Cubo cubo = new Cubo(lado);
            return cubo.VolumenCubo();
            }
            
                throw new Exception("No se puede calcular fuera del rango de 0 y 300");
        }

        public double CalcularRectangulo(double lado,double altura)
        {
            if (lado > 0 && lado < 300 && altura > 0 && lado < 300) 
            {
                Rectangulo rectangulo=new Rectangulo(lado,altura);
            return rectangulo.AreaRectangulo();
            }
            throw new Exception("No se puede calcular fuera del rango de 0 y 300");
           

        }



    }
}

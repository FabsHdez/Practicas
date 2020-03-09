using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaSerie
{
    class Serie
    {
        private string titulo;
        public void getTitulo(String titulo)
        {
            this.titulo = titulo;
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        private int temporadas;
        public void getTemporadas(int temporadas)
        {
            this.temporadas = temporadas;
        }
        public void setTemporadas(int temporadas)
        {
            this.temporadas = temporadas;
        }


        private bool entregado;


        private string genero;
        public void getGenero(string genero)
        {
            this.genero = genero;
        }
        public void setGenero(string genero)
        {
            this.genero = genero;
        }


        private string creador;
        public void getCreador(string creador)
        {
            this.creador = creador;
        }
        public void setCreador(string creador)
        {
            this.creador = creador;
        }


        public Serie()
        {
            titulo = "";
            temporadas = 3;
            entregado = false;
            genero = "";
            creador = "";
        }

        public Serie(String titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;

        }
        public Serie(String titulo, int temporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.temporadas = temporadas;
            this.genero = genero;
            this.creador = creador;
        }

       
        public String MuestraMensaje()
        {

            return "Informacion de la persona: \n"
                    + "Titulo: " + titulo + "\n"
                    + "Temporadas: " + temporadas + "\n"
                    + "Entregado: " + entregado + " \n"
                    + "Genero: " + genero + "\n"
                    + "Creador: " + creador + " \n" +


            "Gracias por participar! \n" + "Por favor precione cualquier tecla para cerrar el programa";


        }
        public String MuestraMensaje1()
        {

            return "Informacion de la persona: \n"
                    + "Titulo: " + titulo + "\n"
                    + "Temporadas: 3 \n"
                    + "Entregado: " + entregado + " \n"
                    + "Genero: accion \n"
                    + "Creador: " + creador + " \n" +
            "Gracias por participar! \n" + "Por favor precione cualquier tecla para cerrar el programa";

        }
        public String MuestraMensaje2()
        {

            return "Informacion de la persona: \n"
                    + "Titulo: Mendez \n"
                    + "Temporadas: 18 \n"
                    + "Entregado:" + entregado + "\n"
                    + "Genero: Accion \n"
                    + "Creador: Paulini Cota \n" +

            "Gracias por participar! \n" + "Por favor precione cualquier tecla para cerrar el programa";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triki_Windows_Form
{
    public partial class Form1 : Form
    {
        int contadorJugadas ;
        int contadorVictoriasA ;
        int contadorVictoriasB ;
        readonly string jugadorA ;
        readonly string jugadorB  ;
        public Form1()
        {
            jugadorA = "X";
            jugadorB = "O";
            contadorJugadas = 0;
            contadorVictoriasA = 0;
            contadorVictoriasB = 0; 
            InitializeComponent();
            
        }

        void asignarSimbolo(ref System.Windows.Forms.Button boton)
        {
            if (contadorJugadas % 2 == 0)
                boton.Text = jugadorA;
            else
                boton.Text = jugadorB;

            boton.Enabled = false;
            contadorJugadas++;
        }

        void habilitarBotones()
        {
            BotonA.Enabled = true;
            BotonB.Enabled = true;
            BotonC.Enabled = true;
            BotonD.Enabled = true;
            BotonE.Enabled = true;
            BotonF.Enabled = true;
            BotonG.Enabled = true;
            BotonH.Enabled = true;
            BotonI.Enabled = true;
        }

        void deshabilitarBotones()
        {
            BotonA.Enabled = false;
            BotonB.Enabled = false;
            BotonC.Enabled = false;
            BotonD.Enabled = false;
            BotonE.Enabled = false;
            BotonF.Enabled = false;
            BotonG.Enabled = false;
            BotonH.Enabled = false;
            BotonI.Enabled = false;
        }

        void comprobarEmpate()
        {
            if (contadorJugadas == 9 && ! ganador(jugadorA) && ! ganador(jugadorB))
                etiquetaEstado.Text = "¡El juego ha concluido en empate!";
        }
        
        void comprobarVictoria()
        {
            if (ganador(jugadorA))
            {
                etiquetaEstado.Text= "¡Ha ganado el jugador X!";
                contadorVictoriasA++;
                etiquetaVictoriasX.Text = "Victorias del jugador X: " + contadorVictoriasA;
            }

            if (ganador(jugadorB))
            {
                etiquetaEstado.Text = "¡Ha ganado el jugador O!";
                contadorVictoriasB++;
                etiquetaVictoriasO.Text = "Victorias del jugador O: " + contadorVictoriasB;
            }
        }

        bool ganador(string jugador)
        {
            bool ganador = false;
            // Se comprueban las victorias en sentido horizontal
            if (BotonA.Text == jugador && BotonB.Text == jugador && BotonC.Text == jugador)
                ganador = true;
            if (BotonD.Text == jugador && BotonE.Text == jugador && BotonF.Text == jugador)
                ganador = true;
            if (BotonG.Text == jugador && BotonH.Text == jugador && BotonI.Text == jugador)
                ganador = true;

            // Se comprueban las victorias en sentido vertical.
            if (BotonA.Text == jugador && BotonD.Text == jugador && BotonG.Text == jugador)
                ganador = true;
            if (BotonB.Text == jugador && BotonE.Text == jugador && BotonH.Text == jugador)
                ganador = true;
            if (BotonC.Text == jugador && BotonF.Text == jugador && BotonI.Text == jugador)
                ganador = true;

            // Se comprueba la victoria en la diagonal principal.
            if (BotonA.Text == jugador && BotonE.Text == jugador && BotonI.Text == jugador)
                ganador = true;

            // Se comprueba la victoria en la diagonal secundaria.
            if (BotonG.Text == jugador && BotonE.Text == jugador && BotonC.Text == jugador)
                ganador = true;

            // Si hay ganador que deshabilite los botones
            if (ganador)
                deshabilitarBotones();


            return ganador;     
        }
        private void BotonA_Click(object sender, EventArgs e)
        {
            asignarSimbolo(ref BotonA);
            comprobarVictoria();
            comprobarEmpate();
            
        }

        private void BotonB_Click(object sender, EventArgs e)
        {
            asignarSimbolo(ref BotonB);
            comprobarVictoria();
            comprobarEmpate();
        }

        private void BotonC_Click(object sender, EventArgs e)
        {
            asignarSimbolo(ref BotonC);
            comprobarVictoria();
            comprobarEmpate();
        }

        private void BotonD_Click(object sender, EventArgs e)
        {
            asignarSimbolo(ref BotonD);
            comprobarVictoria();
            comprobarEmpate();
        }

        private void BotonE_Click(object sender, EventArgs e)
        {
            asignarSimbolo(ref BotonE);
            comprobarVictoria();
            comprobarEmpate();
        }

        private void BotonF_Click(object sender, EventArgs e)
        {
            asignarSimbolo(ref BotonF);
            comprobarVictoria();
            comprobarEmpate();
        }

        private void BotonG_Click(object sender, EventArgs e)
        {
            asignarSimbolo(ref BotonG);
            comprobarVictoria();
            comprobarEmpate();
        }

        private void BotonH_Click(object sender, EventArgs e)
        {
            asignarSimbolo(ref BotonH);
            comprobarVictoria();
            comprobarEmpate();
        }

        private void BotonI_Click(object sender, EventArgs e)
        {
            asignarSimbolo(ref BotonI);
            comprobarVictoria();
            comprobarEmpate();
        }

        private void botonReseteo_Click(object sender, EventArgs e)
        {
        BotonA.Text=
        BotonB.Text =
        BotonC.Text =
        BotonD.Text =
        BotonE.Text =
        BotonG.Text =
        BotonH.Text =
        BotonI.Text = string.Empty;

            habilitarBotones();

            etiquetaEstado.Text = string.Empty;
            contadorJugadas = 0;
        }
    }
}

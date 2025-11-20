using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio01_calculadora
{
    public partial class Form1 : Form
    { 
        bool mostrado = false;
    
        const float NUD_FONTSIZE = 14.00f;
        const float LABEL_FONTSIZE = 10.00f;
        const float TB_FONTSIZE  = 14.00f;
        const float BTN_FONTSIZE = 18.00f;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            mostrado = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (mostrado) {
                float proporciónAlto = this.Height / this.MinimumSize.Height;
                cambiarFuentes(proporciónAlto);
                cambiarAnchosFLP();     
            }           
        }

        private void cambiarFuentes(float proporcionAlto)
        {
            //Cambiar tamaño de fuentes

            lResultado.Font = new Font(lResultado.Font.FontFamily, LABEL_FONTSIZE * proporcionAlto);
            lOperando1.Font = new Font(lOperando1.Font.FontFamily, LABEL_FONTSIZE * proporcionAlto);
            lOperando2.Font = new Font(lOperando2.Font.FontFamily, LABEL_FONTSIZE * proporcionAlto);
            tbResultado.Font = new Font(tbResultado.Font.FontFamily, TB_FONTSIZE * proporcionAlto);
            nudOperando1.Font = new Font(nudOperando1.Font.FontFamily, NUD_FONTSIZE * proporcionAlto);
            nudOperando2.Font = new Font(nudOperando2.Font.FontFamily, NUD_FONTSIZE * proporcionAlto);
            bSumar.Font = new Font(bSumar.Font.FontFamily, BTN_FONTSIZE * proporcionAlto);
            bRestar.Font = new Font(bRestar.Font.FontFamily, BTN_FONTSIZE * proporcionAlto);
            bElevar.Font = new Font(bElevar.Font.FontFamily, BTN_FONTSIZE * proporcionAlto);
            bMultiplicar.Font = new Font(bMultiplicar.Font.FontFamily, BTN_FONTSIZE * proporcionAlto);
            bDividir.Font = new Font(bDividir.Font.FontFamily, BTN_FONTSIZE * proporcionAlto);
            bBorrar.Font = new Font(bBorrar.Font.FontFamily, BTN_FONTSIZE * proporcionAlto);
        }

        private void cambiarAnchosFLP()
        {
            //cambiar anchos de textbox y numericUpDown dentro del FLP

            tbResultado.Width = flpResultado.Width - 6;
            nudOperando1.Width = flpResultado.Width - 6;
            nudOperando2.Width = flpResultado.Width - 6;
        }
    }
}

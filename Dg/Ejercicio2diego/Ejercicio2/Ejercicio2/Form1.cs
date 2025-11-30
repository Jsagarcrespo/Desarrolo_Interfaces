namespace Ejercicio2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            limpiar();
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            /* ESTA PARTE AUN NO SE HA IMPARTIDO EN CLASE

              if (rRectangulo.Checked)
              {
                  double lado = Convert.ToDouble(numLado.Text);
                  double altura = Convert.ToDouble(numAltura.Text);

                  double area = lado * altura;

                  lblResultado.Text = "El área del rectángulo es: " + area.ToString();

              }

            */
        }
        public void limpiar()
        {

            rArea.Checked = true;
            //foreach (Control control in tlp)



                rRectangulo.Visible = true;
            rRectangulo.Checked = false;
            rCirculo.Visible = true;
            rCirculo.Checked = false;
            rArea.Checked = true;
            labelAltura.Visible = false;
            labelLado.Visible = false;
            labelRadio.Visible = false;
            numAltura.Visible = false;
            numLado.Visible = false;
            numRadio.Visible = false;
            rEsfera.Visible = false;
            rCubo.Visible = false;
        }

        private void rArea_CheckedChanged(object sender, EventArgs e)
        {
            rRectangulo.Visible = rArea.Checked;
            rCirculo.Visible = rArea.Checked;

        }
        
        private void Figura_CheckedChange(Object sender, EventArgs e)
        {

        }

        private void rRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            /*  if (rRectangulo.Checked)
            {
                rCirculo.Checked = false;
                rEsfera.Checked = false;
                rCubo.Checked = false;
                labelLado.Visible = true;
                labelAltura.Visible = true;
                labelRadio.Visible = false;
                numLado.Visible = true;
                numAltura.Visible = true;
                numRadio.Visible = false;
            } */

        }

        private void rCirculo_CheckedChanged(object sender, EventArgs e)
        {
            /* if (rCirculo.Checked)
            {
                rRectangulo.Checked = false;
                rEsfera.Checked = false;
                rCubo.Checked = false;
                labelLado.Visible = false;
                labelAltura.Visible = false;
                labelRadio.Visible = true;
                numLado.Visible = false;
                numAltura.Visible = false;
                numRadio.Visible = true;
            } */ 

        }

        private void rEsfera_CheckedChanged(object sender, EventArgs e)
        {
            /* if (rEsfera.Checked)
            {
                rRectangulo.Checked = false;
                rCirculo.Checked = false;
                rCubo.Checked = false;
                labelLado.Visible = false;
                labelAltura.Visible = false;
                labelRadio.Visible = true;
                numLado.Visible = false;
                numAltura.Visible = false;
                numRadio.Visible = true;
            } */
        }

        private void rCubo_CheckedChanged(object sender, EventArgs e)
        { /*
            if (rCubo.Checked)
            {
                rRectangulo.Checked = false;
                rCirculo.Checked = false;
                rEsfera.Checked = false;
                labelLado.Visible = true;
                labelAltura.Visible = false;
                labelRadio.Visible = false;
                numLado.Visible = true;
                numAltura.Visible = false;
                numRadio.Visible = false;
            } */
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            //if (mostrado)
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gMedida_Enter(object sender, EventArgs e)
        {

        }

        private void rVolumen_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

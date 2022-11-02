using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercDGVFormatosYFormatoCondicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Llamamos a la funcion para que nos introduzca los datos
            introduccionDatos(3);

            estilos estilo = new estilos(this.dgv);

            //Introducimos los diferentes estilos
            estilo.definirFilas("#A34896", "#AFF099", "#6BA358", "------------");
            estilo.definirCabecera("#CDFFBD", "#6BA358");
            estilo.definirFilasAlternas("#CDFFBD", "#F17EE1", "************");

            //Ajustamos el tamaño de todas las columnas
            foreach (DataGridViewColumn dgvColumna in this.dgv.Columns)
            {
                dgvColumna.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void introduccionDatos(int numDatos)
        {
            for (int i = 0; i < numDatos; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv);

                fila.Cells[0].Value = i;
                fila.Cells[1].Value = "Montse";
                fila.Cells[2].Value = "Garrido";
                fila.Cells[3].Value = "Valero";
                fila.Cells[4].Value = "Baeza";
                fila.Cells[5].Value = "15/08/1989";
                fila.Cells[6].Value = "A";
                fila.Cells[7].Value = 900.20;

                dgv.Rows.Add(fila);
            }

            DataGridViewRow fila1 = new DataGridViewRow();
            fila1.CreateCells(dgv);

            fila1.Cells[0].Value = 4;
            fila1.Cells[1].Value = "Pepa";
            fila1.Cells[2].Value = "Garrido";
            fila1.Cells[3].Value = "Valero";
            fila1.Cells[4].Value = "Baeza";
            fila1.Cells[5].Value = "15/08/1998";
            fila1.Cells[6].Value = "B";
            fila1.Cells[7].Value = 960.20;

            dgv.Rows.Add(fila1);

            DataGridViewRow fila2 = new DataGridViewRow();
            fila2.CreateCells(dgv);

            fila2.Cells[0].Value = 5;
            fila2.Cells[1].Value = "Carlos";
            fila2.Cells[2].Value = "Vargas";
            fila2.Cells[3].Value = "Valero";
            fila2.Cells[4].Value = "Baeza";
            fila2.Cells[5].Value = "06/11/1988";
            fila2.Cells[6].Value = "C";
            fila2.Cells[7].Value = 1960.20;

            dgv.Rows.Add(fila2);

            this.dgv.Columns[0].ValueType = Type.GetType("System.Integer");
            this.dgv.Columns[1].ValueType = Type.GetType("System.String");
            this.dgv.Columns[2].ValueType = Type.GetType("System.String");
            this.dgv.Columns[3].ValueType = Type.GetType("System.String");
            this.dgv.Columns[4].ValueType = Type.GetType("System.String");
            this.dgv.Columns[5].ValueType = Type.GetType("System.DateTime");
            this.dgv.Columns[6].ValueType = Type.GetType("System.Char");
            this.dgv.Columns[7].ValueType = Type.GetType("System.Double");
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv.Columns[e.ColumnIndex].Name == "ColumnTipoCliente")
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "A")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(163, 72, 150);
                        e.CellStyle.BackColor = Color.White;
                        e.CellStyle.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
                    }
                    if (e.Value.ToString() == "B")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(107, 163, 88);
                        e.CellStyle.BackColor = Color.White;
                        e.CellStyle.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
                    }
                    if (e.Value.ToString() == "C")
                    {
                        e.CellStyle.ForeColor = Color.FromArgb(241, 126, 225);
                        e.CellStyle.BackColor = Color.White;
                        e.CellStyle.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
                    }
                }
            }
        }
    }
}